﻿using Entities.ErrorModel;
using Entities.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using NLog.LayoutRenderers;
using Services.Contracts;
using System.Net;

namespace WebApi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this WebApplication app,ILoggerService logger) 
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context => 
                {
                    
                    context.Response.ContentType= "application/json";

                    var contextFeatures = context.Features.Get<IExceptionHandlerFeature>();
                    if(contextFeatures is not null) 
                    {
                        context.Response.StatusCode = contextFeatures.Error switch
                        {
                            NotFoundException=>StatusCodes.Status404NotFound,
                            _=>StatusCodes.Status500InternalServerError
                        };
                        logger.LogError($"Something went wrong: {contextFeatures.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message=contextFeatures.Error.Message
                        }.ToString());
                    }
                });
            });
        } 
    }
}

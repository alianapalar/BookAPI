using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CategoriesController(IServiceManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            return Ok(await _manager.CategoryService.GetAllCategoriesAsync(false));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAllCategoriesAsync([FromRoute] int id)
        {
            return Ok(await _manager.CategoryService.GetOneCategoryByIdAsync(id,false));
        }
        [HttpPost(Name ="CreateOneCategoryAsync")]
        public async Task<IActionResult> CreateOneCategoryAsync([FromBody] CategoryDtoForInsertion categoryDto) 
        {
            var category= await _manager.CategoryService.CreateOneCategoryAsync(categoryDto);
            return StatusCode(201, category);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneCategoryAsync([FromRoute]int id, [FromBody] CategoryDtoForUpdate categoryDto) 
        {
            var entity = await _manager.CategoryService.GetOneCategoryByIdAsync(id, false);
            await _manager.CategoryService.UpdateOneCategoryAsync(categoryDto,id,false);
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneCategoryAsync([FromRoute(Name = "id")] int id) 
        {
            var entity = await _manager.CategoryService.GetOneCategoryByIdAsync(id, false);
            await _manager.CategoryService.DeleteOneCategoryAsync(id, false);
            return NoContent();
        }
    }
}

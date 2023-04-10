using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record CategoryDtoForUpdate:CategoryDtoForManipulation
    {
        public int CategoryId { get; init; }
    }
}

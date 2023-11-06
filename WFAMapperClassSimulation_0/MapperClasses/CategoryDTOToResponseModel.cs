using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAMapperClassSimulation_0.Models;

namespace WFAMapperClassSimulation_0.MapperClasses
{
    public static class CategoryDTOToResponseModel
    {
        public static CategoryResponseModel MapDTOToResponse(CategoryDTO categoryDTO)
        {
            return new CategoryResponseModel()
            {

                CategoryName = categoryDTO.CategoryName,
                Description = categoryDTO.Description,
                ID = categoryDTO.ID
            };
        }
    }
}

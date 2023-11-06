using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAMapperClassSimulation_0.Models;

namespace WFAMapperClassSimulation_0.MapperClasses
{
    public static class CategoryDomainToDTO
    {
        public static CategoryDTO MapCategoryToDTO(Category category)
        {
            return new CategoryDTO
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                CreatedDate = category.CreatedDate,
                ID = category.ID,   
            };
        }
    }
}

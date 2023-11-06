using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMapperClassSimulation_0.Models
{
    public class CategoryResponseModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public string FullName
        {
            get
            {
                return $"{CategoryName} {Description}";
            }
        }

    }
}

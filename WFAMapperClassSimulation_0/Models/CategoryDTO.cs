using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMapperClassSimulation_0.Models
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }    //Özel CreatedDate ile ilgili iş akısı

    }
}

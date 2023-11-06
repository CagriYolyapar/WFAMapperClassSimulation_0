﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMapperClassSimulation_0.Models
{
    //Domain Entity
    public class Category
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


    }
}

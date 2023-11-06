using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAMapperClassSimulation_0.MapperClasses;
using WFAMapperClassSimulation_0.Models;

namespace WFAMapperClassSimulation_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Domain Entity
            Category c = new Category();
            c.ID = 1;
            c.CategoryName = "Tatlılar";
            c.Description = "Deneme verisidir";


            //DTO (Data Transfer Object)

            CategoryDTO cDto = CategoryDomainToDTO.MapCategoryToDTO(c);


            //Response Model(View Model)
            CategoryResponseModel crp = CategoryDTOToResponseModel.MapDTOToResponse(cDto);

           

        }
    }
}

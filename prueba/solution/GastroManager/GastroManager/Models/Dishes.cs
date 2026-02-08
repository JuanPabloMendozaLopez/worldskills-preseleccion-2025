using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Entidades
{
    public class Dishes
    {

        public int DishId { get; set; }
        public string DishName { get; set; } = null!;
        public int BaseServings { get; set; } 
        public int CategoryId { get; set; }
        public string ImagePath { get; set; } = null!;
        public string SourceRecipeLink { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal FinalPriceForClients { get; set; } 



    }
}

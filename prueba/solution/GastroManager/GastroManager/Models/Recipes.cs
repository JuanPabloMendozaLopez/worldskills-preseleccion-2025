using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Entidades
{
    public class Recipes
    {

        public int RecipeId { get; set; }
        public int DishId { get; set; }
        public string ProcessDescription { get; set; } = null!;
        public int TimeInMinutes { get; set; }

    }
}

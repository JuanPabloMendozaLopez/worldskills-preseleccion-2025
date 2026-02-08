using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Entidades
{
    public class Dishes_Ingredients
    {

        public int Dish_Id { get; set; }
        public int Ingredient_Id { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; } = null!;

    }
}

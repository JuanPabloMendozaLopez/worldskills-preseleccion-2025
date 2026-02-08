using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Entidades
{
    public class Ingredients
    {

        public int IngredientId { get; set; }
        public string IngredientName { get; set; } = null!;
        public decimal PricePerUnit { get; set; }
        public string MainUnit { get; set; } = null!;
        public int AvailableCountInStock { get; set; }


    }
}

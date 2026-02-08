using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.DTOs
{
    public class IngredientReadDTO
    {

        public int AvailableCountInStock { get; set; }
        public string IngredientName { get; set; } = null!;
        public int Quantity { get; set; }
        public string MainUnit { get; set; } = null!;
        public decimal PricePerUnit { get; set; }


    }
}

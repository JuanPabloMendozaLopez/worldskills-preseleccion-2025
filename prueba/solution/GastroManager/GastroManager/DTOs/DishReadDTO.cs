using GastroManager.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GastroManager.DTOs
{
    public class DishReadDTO
    {

        public int DishId { get; set; }
        public string DishName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public int BaseServings { get; set; }
        public int Time { get; set; }
        public decimal FinalPriceForClients { get; set; }
        public string Description { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public List<IngredientReadDTO> Ingredients { get; set; } = new List<IngredientReadDTO>();

    }
}

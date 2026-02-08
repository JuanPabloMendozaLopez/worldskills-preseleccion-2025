using GastroManager.DTOs;
using GastroManager.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Interfaces
{
    public interface IIngredientsRepository
    {

        List<Ingredients> Select();
        List<IngredientReadDTO> SelectByDishId(int Id);
        string Delete(int id);
        void UpdateStock(int id, int stock);

    }
}

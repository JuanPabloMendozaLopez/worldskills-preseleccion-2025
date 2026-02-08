using GastroManager.DTOs;
using GastroManager.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Interfaces
{
    public interface IDishesRepository
    {

        List<Dishes> Filter(string categoryName, 
                            string dishName, 
                            bool availableIngredients, 
                            int minPrice, int maxPrice);

        List<Dishes> Select();

        DishReadDTO? GetById(int Id);
        void UpdateServings(int dishId, int baseServings);

    }
}

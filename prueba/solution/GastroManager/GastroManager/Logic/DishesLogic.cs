using GastroManager.DTOs;
using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class DishesLogic
    {

        private readonly IDishesRepository _repo;
        private readonly IIngredientsRepository _repoIngredients;

        public DishesLogic(IDishesRepository repo, IIngredientsRepository repoIngredients) 
        { 
        
            _repo = repo;
            _repoIngredients = repoIngredients;

        }

        public void ChangeServings(int dishId, int baseServings)
        {

            _repo.UpdateServings(dishId, baseServings);

        }

        public List<Dishes> GetFilteredDishes(string categoryName, string dishName, bool availableIngredients, int minPrice, int maxPrice)
        {

            return _repo.Filter(categoryName, dishName, availableIngredients, minPrice, maxPrice);

        }

        public List<Dishes> GetDishes()
        {

            return _repo.Select();

        }

        public DishReadDTO? GetDish(int Id)
        {
            //Obtener plato
            var dish = _repo.GetById(Id);

            if (dish == null)
            {

                return null;
                
            }

            //Obtener ingredientes del plato
            dish.Ingredients = _repoIngredients.SelectByDishId(Id);

            return dish;


        }

    }
}

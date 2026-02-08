using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class RecipeLogic
    {

        private readonly IRecipeRepository _repo;
        
        public RecipeLogic(IRecipeRepository repo) 
        {

            _repo = repo;
        
        
        }

        public List<string> GetRecipeOfDish(int dishId)
        {

            return _repo.RecipeByDishID(dishId);
        }

    }
}

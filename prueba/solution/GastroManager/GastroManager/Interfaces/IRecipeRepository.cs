using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Interfaces
{
    public interface IRecipeRepository
    {

        List<string> RecipeByDishID(int dishId);


    }
}

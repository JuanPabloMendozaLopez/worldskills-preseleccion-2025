using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class CategoriesLogic
    {

        private readonly ICategoryRepository _repo;

        public CategoriesLogic(ICategoryRepository repo) 
        { 
        
            _repo = repo;

        }

        public List<Categories> GetCategories()
        {

            return _repo.ListCategories();

        }

    }
}

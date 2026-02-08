using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class IngredientsLogic
    {

        private IIngredientsRepository _repo;

        public IngredientsLogic(IIngredientsRepository repo) 
        {
        
            _repo = repo;

        }

        public List<Ingredients> GetIngredients()
        {

            return _repo.Select();

        }

        public string Delete(int id)
        {

            string messageContent = _repo.Delete(id);

            if (messageContent.StartsWith("Error: "))
            {

                messageContent.Replace("Error: ", "");

                return messageContent;


            }

            return messageContent;

        }

        public void ChangeStock(int id, int stock)
        {

            _repo.UpdateStock(id, stock);

        }

    }
}

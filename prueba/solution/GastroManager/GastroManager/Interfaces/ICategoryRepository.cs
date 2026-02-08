using GastroManager.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Interfaces
{
    public interface ICategoryRepository
    {

        List<Categories> ListCategories();

    }
}

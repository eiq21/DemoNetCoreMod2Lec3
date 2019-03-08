using NorthWind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWind.Services
{
   public  interface ICategoryOperations
    {
        Category Create(Category category);
        Category GetByID(int categoryID);
        bool Update(Category category);
        bool Delete(int categoryID);
        List<Category> GetAll();
        bool DeleteWithLog(int CategoryID);
    }
}

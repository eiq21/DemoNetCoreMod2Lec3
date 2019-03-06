using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Entities;


namespace NorthWind.Services
{
    public interface INorthWindRepository : IDisposable
    {
        Category Create(Category category);
        Category GetByID(int categoryID);
        bool Update(Category category);
        bool Delete(int categoryID);
        List<Category> GetAll();
        List<Log> GetLogs();
        Log CreateLog(Log log);
        int SaveChanges();
        
    }
}

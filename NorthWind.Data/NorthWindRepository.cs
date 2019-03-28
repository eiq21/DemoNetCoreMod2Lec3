using System;
using System.Collections.Generic;
using System.Text;

using NorthWind.Entities;
using NorthWind.Services;
using System.Linq;

namespace NorthWind.Data
{
    public class NorthWindRepository : INorthWindRepository, IDisposable
    {
        NorthWindContext context;
        bool IsUnitOfWork;

        public NorthWindRepository(bool isUnitOfWork = false)
        {
            this.context = new NorthWindContext();
            this.IsUnitOfWork = isUnitOfWork;
        }

        public Category Create(Category category)
        {
            category = context.Add(category).Entity;
            Save();
            return category;
        }

        public Log CreateLog(Log log)
        {
            log = context.Add(log).Entity;
            Save(); 
            return log;
        }

        public bool Delete(int CategoryID)
        {
            context.Remove(new Category() { CategoryID = CategoryID });
            return Save();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<Category> GetAll()
        {
            return context.Category.ToList();
        }

        public Category GetByID(int categoryID)
        {
           return context.Find<Category>(categoryID);
        }

        public List<Log> GetLogs()
        {
            return context.Log.ToList();
        }

        public int SaveChanges()
        {
            var result = 0;
            if (context != null)
            {
                try
                {
                    result = context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return result;
        }

        private bool Save() {
            int changes = 0;
            if (!IsUnitOfWork) {
                changes = SaveChanges();
            }
            return changes == 1;
        }

        public bool Update(Category category)
        {
            context.Update(category);
            return Save();
            
        }
    }
}

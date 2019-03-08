using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Data;
using NorthWind.Entities;
using NorthWind.Services;

namespace NorthWind.BusinessLogic
{
    public class CategoryOperations : ICategoryOperations
    {
        public Category Create(Category category)
        {
            if (!string.IsNullOrWhiteSpace(category.CategoryName))
            {
                using (var repository = NorthWindRepositoryFactory.GetNorthWindRepository())
                {
                    category = repository.Create(category);
                }
            }
            else
            {
                category = null;
            }
            return category;
        }

        public bool Delete(int categoryID)
        {
            bool result = false;
            using (var repository = NorthWindRepositoryFactory.GetNorthWindRepository())
            {
                result = repository.Delete(categoryID);
            }
            return result;
        }

        public bool DeleteWithLog(int CategoryID)
        {
            bool result = false;
            using (var repository = NorthWindRepositoryFactory.GetNorthWindRepository())
            {
                 repository.Delete(CategoryID);
                Log log = new Log()
                {
                    Type = LogType.DeleteCategory,
                    Message = $"ID: {CategoryID}"
                };
                repository.CreateLog(log);
                result = repository.SaveChanges() == 2;

            }
            return result;
        }

        public List<Category> GetAll()
        {
            return NorthWindRepositoryFactory.GetNorthWindRepository().GetAll();
        }

        public Category GetByID(int categoryID)
        {
            Category category = null;
            if (categoryID  > 0)
            {
                using (var repository = NorthWindRepositoryFactory.GetNorthWindRepository())
                {
                    category = repository.GetByID(categoryID);
                }
            }
            return category;
        }

        public bool Update(Category category)
        {
            bool result = false;
            using (var repository = NorthWindRepositoryFactory.GetNorthWindRepository())
            {
                result = repository.Update(category);
            }
            return result;
        }
    }
}

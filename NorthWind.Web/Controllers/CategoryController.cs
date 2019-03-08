using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Entities;
using NorthWind.Services;

namespace NorthWind.Web.Controllers
{

    public class CategoryController : Controller
    {
        ICategoryOperations _categoryOperations;
        public CategoryController(ICategoryOperations categoryOperations)
        {
            this._categoryOperations = categoryOperations;
        }

        public IActionResult Create(string name, string description)
        {
            Category category = new Category()
            {
                CategoryName = name,
                Description = description
            };

            category = _categoryOperations.Create(category);

            return (category != null) ? Content($"Entidad insertada {category.CategoryID}") : Content("No se pudo insertar la categoria");

        }

        public IActionResult GetByID(int categoryID)
        {
            var category = _categoryOperations.GetByID(categoryID);
            return (category != null) ? Content($"Entidad  {category.CategoryID}, {category.CategoryName}") : Content("No se pudo encontrar la categoria");
        }

        public IActionResult Update(Category category)
        {
            var result = _categoryOperations.Update(category);
            return (result) ? Content("Categoría modificada") : Content("No se actualizó la categoria");
        }

        public IActionResult Delete(int categoryID,bool withLog = false) {
            var result = (withLog) ? _categoryOperations.DeleteWithLog(categoryID) : _categoryOperations.Delete(categoryID);
            return (result) ? Content("Categoria eliminada") : Content("No se puedo eliminar la categoría");
        }

        public IActionResult GetAll() {
            return View(_categoryOperations.GetAll());
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }

    }

}


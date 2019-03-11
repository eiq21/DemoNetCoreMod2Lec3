using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Services;

namespace NorthWind.Web.Controllers
{
    public class LogController : Controller
    {
        private ILogOperations _logOperations;
        public LogController(ILogOperations logOperations)
        {
            this._logOperations = logOperations;
        }
        public IActionResult Index()
        {
            
            return View(_logOperations.GetAll());
        }
    }
}
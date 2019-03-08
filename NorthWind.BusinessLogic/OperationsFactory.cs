using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Services;

namespace NorthWind.BusinessLogic
{
    public static class OperationsFactory
    {
        public static ICategoryOperations GetCategoryOperations() {
            return new CategoryOperations();
        }

        public static ILogOperations GetlogOperations() {
            return new LogOperations();
        }
    }
}

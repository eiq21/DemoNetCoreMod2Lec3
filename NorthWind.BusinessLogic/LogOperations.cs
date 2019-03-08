using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Entities;
using NorthWind.Services;
using NorthWind.Data;



namespace NorthWind.BusinessLogic
{
    public class LogOperations : ILogOperations
    {
        public List<Log> GetAll()
        {
            return NorthWindRepositoryFactory.GetNorthWindRepository().GetLogs();
        }
    }
}

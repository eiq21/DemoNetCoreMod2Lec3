using NorthWind.Entities;
using System.Collections.Generic;

namespace NorthWind.Services
{
    public interface ILogOperations
    {
        List<Log> GetAll();

    }
}

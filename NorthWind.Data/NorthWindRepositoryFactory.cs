using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Services;

namespace NorthWind.Data
{
    public static class NorthWindRepositoryFactory
    {
        public static INorthWindRepository GetNorthWindRepository(bool isUnitOfWork = false)
        {
            return new NorthWindRepository(isUnitOfWork);
        }
    }
}

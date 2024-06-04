using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartphoneFactory.Products;

namespace SmartphoneFactory.Factories
{
    public class PerformanceSmartphoneFactory : ISmartphoneFactory
    {
        public ISmartphone CreateSmartphone()
        {
            return new PerformanceSmartphone();
        }
    }
}


using SmartphoneFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneFactory.Factories
{
    public interface ISmartphoneFactory
    {
        ISmartphone CreateSmartphone();
    }
}

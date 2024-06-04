using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartphoneFactory.Products;

namespace SmartphoneFactory.Factories
{
    public class CameraSmartphoneFactory : ISmartphoneFactory
    {
        public ISmartphone CreateSmartphone()
        {
            return new CameraSmartphone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneFactory.Products
{
    public class CameraSmartphone : ISmartphone
    {
        public void Display()
        {
            Console.WriteLine("Smartphone with advanced camera for photo and video shooting.");
        }
    }
}
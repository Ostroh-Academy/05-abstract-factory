using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneFactory.Products
{
    public class PerformanceSmartphone : ISmartphone
    {
        public void Display()
        {
            Console.WriteLine("Performance smartphone with focus on gaming and productivity.");
        }
    }
}
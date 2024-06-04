using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartphoneFactory.Factories;
using SmartphoneFactory.Products;

namespace SmartphoneFactory
{
    public class Client
    {
        private readonly ISmartphone _smartphone;

        public Client(ISmartphoneFactory factory)
        {
            _smartphone = factory.CreateSmartphone();
        }

        public void Run()
        {
            _smartphone.Display();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Products
{
    public class ElectronicProduct : IProduct
    {
        public void Display()
        {
            Console.WriteLine("Displaying electronic product.");
        }
    }
}

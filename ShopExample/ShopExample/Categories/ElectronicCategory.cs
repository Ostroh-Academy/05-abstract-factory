using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Categories
{
    public class ElectronicCategory : ICategory
    {
        public void ListProducts()
        {
            Console.WriteLine("Listing electronic products.");
        }
    }
}

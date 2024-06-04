using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Categories
{
    public class ClothingCategory : ICategory
    {
        public void ListProducts()
        {
            Console.WriteLine("Listing clothing products.");
        }
    }
}

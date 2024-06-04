using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopExample.Products;
using ShopExample.Categories;

namespace ShopExample.Factories
{
    public class ElectronicShopFactory : IShopFactory
    {
        public IProduct CreateProduct()
        {
            return new ElectronicProduct();
        }

        public ICategory CreateCategory()
        {
            return new ElectronicCategory();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopExample.Products;
using ShopExample.Categories;

namespace ShopExample.Factories
{
    public class ClothingShopFactory : IShopFactory
    {
        public IProduct CreateProduct()
        {
            return new ClothingProduct();
        }

        public ICategory CreateCategory()
        {
            return new ClothingCategory();
        }
    }
}



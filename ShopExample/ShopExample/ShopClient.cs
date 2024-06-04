using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopExample.Factories;
using ShopExample.Products;
using ShopExample.Categories;

namespace ShopExample
{
    public class ShopClient
    {
        private readonly IProduct _product;
        private readonly ICategory _category;

        public ShopClient(IShopFactory factory)
        {
            _product = factory.CreateProduct();
            _category = factory.CreateCategory();
        }

        public void Run()
        {
            _product.Display();
            _category.ListProducts();
        }
    }
}

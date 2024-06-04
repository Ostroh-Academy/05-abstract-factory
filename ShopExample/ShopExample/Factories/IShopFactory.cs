using ShopExample.Categories;
using ShopExample.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopExample.Factories
{
    public interface IShopFactory
    {
        IProduct CreateProduct();
        ICategory CreateCategory();
    }
}

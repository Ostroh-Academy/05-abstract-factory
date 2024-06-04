using System;

interface IProduct
{
    string Name { get; }
}

class FaceCream : IProduct
{
    public string Name => "Face Cream";
}

class FaceWash : IProduct
{
    public string Name => "Face Wash";
}

class BodyLotion : IProduct
{
    public string Name => "Body Lotion";
}

class BodyWash : IProduct
{
    public string Name => "Body Wash";
}

class Shampoo : IProduct
{
    public string Name => "Shampoo";
}

class Conditioner : IProduct
{
    public string Name => "Conditioner";
}

interface IBeautyProductFactory
{
    IProduct CreateFaceProduct();
    IProduct CreateBodyProduct();
    IProduct CreateHairProduct();
}

class NaturalBeautyProductFactory : IBeautyProductFactory
{
    public IProduct CreateFaceProduct()
    {
        return new FaceCream();
    }

    public IProduct CreateBodyProduct()
    {
        return new BodyLotion(); 
    }

    public IProduct CreateHairProduct()
    {
        return new Shampoo(); 
    }
}

class OrganicBeautyProductFactory : IBeautyProductFactory
{
    public IProduct CreateFaceProduct()
    {
        return new FaceWash(); 
    }

    public IProduct CreateBodyProduct()
    {
        return new BodyWash(); 
    }

    public IProduct CreateHairProduct()
    {
        return new Conditioner(); 
    }
}

class CosmeticProductCreator
{
    private readonly IBeautyProductFactory _factory;

    public CosmeticProductCreator(IBeautyProductFactory factory)
    {
        _factory = factory;
    }

    public void CreateProducts()
    {
        var faceProduct = _factory.CreateFaceProduct();
        var bodyProduct = _factory.CreateBodyProduct();
        var hairProduct = _factory.CreateHairProduct();
        Console.WriteLine($"Face Product: {faceProduct.Name}");
        Console.WriteLine($"Body Product: {bodyProduct.Name}");
        Console.WriteLine($"Hair Product: {hairProduct.Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var organicFactory = new OrganicBeautyProductFactory();
        var organicProductCreator = new CosmeticProductCreator(organicFactory);
        organicProductCreator.CreateProducts();

        Console.WriteLine();
        var naturalFactory = new NaturalBeautyProductFactory();
        var naturalProductCreator = new CosmeticProductCreator(naturalFactory);
        naturalProductCreator.CreateProducts();
    }
}






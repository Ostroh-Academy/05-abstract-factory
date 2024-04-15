namespace Lab_6_patterns.Factory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}

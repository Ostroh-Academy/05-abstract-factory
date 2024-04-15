namespace Lab_6_patterns.Factory
{
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}

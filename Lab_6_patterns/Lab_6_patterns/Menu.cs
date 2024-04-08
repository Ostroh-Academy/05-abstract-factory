using Lab_6_patterns.Factory;

namespace Lab_6_patterns
{
    public class Menu
    {
        private Chair chair;
        private Sofa sofa;

        public Menu(FurnitureFactory factory)
        {
            chair = factory.CreateChair();
            sofa = factory.CreateSofa();
        }

        public void SitOnChair()
        {
            chair.Sit();
        }

        public void LieOnSofa()
        {
            sofa.Lie();
        }
    }
}

namespace Lab_05_Zahrebelnyi
{
    public class DarkUIFactory : IUIFactory
    {
        public void CreateButton(string width, string height, string font, string text)
        {
            Console.WriteLine($"Created dark button for Dark theme, with: {width}x{height} size, {font} font and \"{text}\" text.");
        }

        public void CreateTextField(string width, string height, string font)
        {
            Console.WriteLine($"Created dark text field for Dark theme, with: {width}x{height} size and {font} font.");
        }
    }
}
namespace Lab_05_Zahrebelnyi
{
    public interface IUIFactory
    {
        void CreateButton(string width, string height, string font, string text);
        void CreateTextField(string width, string height, string font);
    }
}
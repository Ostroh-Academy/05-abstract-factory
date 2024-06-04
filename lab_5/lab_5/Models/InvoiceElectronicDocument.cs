using System;
namespace lab_5
{
    public class InvoiceElectronicDocument : IElectronicDocument
    {
        public void Display()
        {
            Console.WriteLine("Displaying electronic invoice...");
        }

        public void Save()
        {
            Console.WriteLine("Saving electronic invoice...");
        }
    }
}


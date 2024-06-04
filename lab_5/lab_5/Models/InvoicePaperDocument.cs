using System;
namespace lab_5
{
    public class InvoicePaperDocument : IPaperDocument
    {
        public void Print()
        {
            Console.WriteLine("Printing paper invoice...");
        }

        public void Archive()
        {
            Console.WriteLine("Archiving paper invoice...");
        }
    }
}


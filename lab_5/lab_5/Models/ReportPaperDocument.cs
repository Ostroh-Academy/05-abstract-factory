using System;
namespace lab_5
{
    public class ReportPaperDocument : IPaperDocument
    {
        public void Print()
        {
            Console.WriteLine("Printing paper report...");
        }

        public void Archive()
        {
            Console.WriteLine("Archiving paper report...");
        }
    }
}


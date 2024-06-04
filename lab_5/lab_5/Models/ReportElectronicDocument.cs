using System;
namespace lab_5
{
    public class ReportElectronicDocument : IElectronicDocument
    {
        public void Display()
        {
            Console.WriteLine("Displaying electronic report...");
        }

        public void Save()
        {
            Console.WriteLine("Saving electronic report...");
        }
    }
}


using System;
namespace lab_5
{
    public class ReportDocumentFactory : IDocumentFactory
    {
        public IPaperDocument CreatePaperDocument()
        {
            return new ReportPaperDocument();
        }

        public IElectronicDocument CreateElectronicDocument()
        {
            return new ReportElectronicDocument();
        }
    }
}


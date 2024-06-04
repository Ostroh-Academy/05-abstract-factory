using System;
namespace lab_5
{
    public class InvoiceDocumentFactory : IDocumentFactory
    {
        public IPaperDocument CreatePaperDocument()
        {
            return new InvoicePaperDocument();
        }

        public IElectronicDocument CreateElectronicDocument()
        {
            return new InvoiceElectronicDocument();
        }
    }
}


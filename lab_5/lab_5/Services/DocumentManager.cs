using System;
namespace lab_5
{
    public class DocumentManager
    {
        private readonly IPaperDocument _paperDocument;
        private readonly IElectronicDocument _electronicDocument;

        public DocumentManager(IDocumentFactory factory)
        {
            _paperDocument = factory.CreatePaperDocument();
            _electronicDocument = factory.CreateElectronicDocument();
        }

        public void ProcessDocuments()
        {
            _paperDocument.Print();
            _paperDocument.Archive();
            _electronicDocument.Display();
            _electronicDocument.Save();
        }
    }

}


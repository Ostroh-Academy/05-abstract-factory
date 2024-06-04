using lab_5;

class Program
{
    static void Main(string[] args)
    {
        IDocumentFactory reportFactory = new ReportDocumentFactory();
        DocumentManager reportManager = new DocumentManager(reportFactory);
        reportManager.ProcessDocuments();
        Console.WriteLine($"\n");
        IDocumentFactory invoiceFactory = new InvoiceDocumentFactory();
        DocumentManager invoiceManager = new DocumentManager(invoiceFactory);
        invoiceManager.ProcessDocuments();
    }
}

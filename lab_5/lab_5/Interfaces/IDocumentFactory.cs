using System;
namespace lab_5
{
	public interface IDocumentFactory
	{
        IPaperDocument CreatePaperDocument();
        IElectronicDocument CreateElectronicDocument();
    }
}


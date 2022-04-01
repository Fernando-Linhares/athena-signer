using BaseDocument = AthenaSigner.Signer.RunTime.Concepts.Document;

namespace AthenaSigner.Signer.RunTime;

public class Document : BaseDocument, IDocument
{
    private string _pathFile;
    public Document(string pathFile)
    {
        _pathFile = pathFile;
    }
}
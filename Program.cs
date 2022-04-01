using AthenaSigner.Signer.RunTime;
using AthenaSigner.Signer.RunTime.Values;

namespace AthenaSigner;

public class Program
{
    public static void Main(string[] args)
    {
        string pathFile = args[0];

        Cryp algorithm = new Cryp(Algorithm.EAS256);

        Key key = new Key(Certificate.A3);

        Document file = new Document(pathFile);

        AthenaSigner.Signer.Pkcs.Signer.Sign(algorithm, key, file);
    }
}
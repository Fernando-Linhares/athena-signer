using AthenaSigner.Signer.RunTime.Values;
using AthenaSigner.Signer.RunTime.Concepts;

namespace AthenaSigner.Signer.RunTime;

public class Cryp  : Cryptography, ICryptography
{
    private Algorithm _algorithm;
    public Cryp(Algorithm algorithm)
    {
        _algorithm = algorithm;
    }

    public void SignOrFail(IDocument document)
    {}

    public void Use(IKey key)
    {}
}
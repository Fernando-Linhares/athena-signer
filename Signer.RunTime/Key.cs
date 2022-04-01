using AthenaSigner.Signer.RunTime.Values;
using BaseKey = AthenaSigner.Signer.RunTime.Concepts.Key;

namespace AthenaSigner.Signer.RunTime;

public class Key : BaseKey, IKey
{
    private Certificate _certificate;
    public Key(Certificate certificate)
    {
        _certificate = certificate;
    }
}
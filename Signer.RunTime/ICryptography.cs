using System;

namespace AthenaSigner.Signer.RunTime;

public interface ICryptography
{
    public void SignOrFail(IDocument document);

    public void Use(IKey key);
}
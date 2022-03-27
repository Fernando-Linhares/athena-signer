namespace AthenaSigner.Source.Signer.Contract;

public interface ISigner
{
    public void Sign(string path, object keystore, object certificate);
}
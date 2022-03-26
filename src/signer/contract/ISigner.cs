namespace AthenaSigner.src.signer.contract;

public interface ISigner
{
    public void Sign(string path, object keystore, object certificate);
}
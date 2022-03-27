namespace AthenaSigner.Source;

using AthenaSigner.Source.Utils.Core;
using AthenaSigner.Source.Utils.Provider;
using AthenaSigner.Source.Utils.Provider.Contract;
using AthenaSigner.Source.Signer;
using AthenaSigner.Source.Signer.Contract;

public class Runner
{
    public static void Start()
    {
        IProvider provider;
        ISigner signer;
        Core core;


        provider   =  GetProvider();
        signer     =  GetSigner();

        core       = Core.Use(provider, signer);

        core.SignOrFail();
    }

    public static IProvider GetProvider()
    {
        Provider provider = new Provider();

        provider.Add("certificade", new object());
        
        return provider;
    }

    public static ISigner GetSigner()
    {
        return new SignerDocument();
    }
}
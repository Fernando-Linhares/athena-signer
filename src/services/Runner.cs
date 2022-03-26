using AthenaSigner.src.utils.core;
using AthenaSigner.src.utils.provider;
using AthenaSigner.src.utils.provider.contract;
using AthenaSigner.src.signer;
using AthenaSigner.src.signer.contract;

namespace AthenaSigner.src.services;

public class Runner
{
    public static void Start()
    {
        IProvider provider;
        ISigner signer;
        Core core;


        provider   =  GetProvider();
        signer     =  GetSigner();

        core       = Core.use(provider, signer);

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
        return new Signer();
    }
}
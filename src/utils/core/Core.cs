using System;
using AthenaSigner.src.utils.provider.contract;
using AthenaSigner.src.utils.core.contract;
using AthenaSigner.src.signer.contract;

namespace AthenaSigner.src.utils.core;

class Core : ICore
{
    private IProvider _provider { get; set; }

    private ISigner _signer { get; set; }

    public Core(IProvider provider, ISigner signer)
    {
        _provider = provider;
        _signer   = signer;
    }

    public static Core use(IProvider provider, ISigner signer)
    {
        return new Core(provider, signer);
    } 

    public void SignOrFail()
    {
        try{
            // _signer.sign();

        }catch(Exception exception){
            Console.WriteLine(exception.GetBaseException());
        }
    } 
}
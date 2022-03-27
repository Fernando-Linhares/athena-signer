namespace AthenaSigner.Source.Utils.Core;

using System;
using AthenaSigner.Source.Utils.Provider.Contract;
using AthenaSigner.Source.Utils.Core.Contract;
using AthenaSigner.Source.Signer.Contract;

class Core : ICore
{
    private IProvider _Provider { get; set; }

    private ISigner _Signer { get; set; }

    public Core(IProvider Provider, ISigner Signer)
    {
        _Provider = Provider;
        _Signer   = Signer;
    }

    public static Core Use(IProvider Provider, ISigner Signer)
    {
        return new Core(Provider, Signer);
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
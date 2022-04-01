using AthenaSigner.Signer.RunTime;

namespace AthenaSigner.Signer.Pkcs;

public class Signer
{
    public static void Sign(ICryptography algorithm, IKey key , IDocument file)
    {
        try{

            algorithm.Use(key);

            algorithm.SignOrFail(file);

        }catch(Exception exception){

            Console.WriteLine(exception.GetBaseException());

        }
    }
}
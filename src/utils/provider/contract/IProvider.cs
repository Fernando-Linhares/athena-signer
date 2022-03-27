namespace  AthenaSigner.Source.Utils.Provider.Contract;

public interface IProvider
{
    public void Add(string name, object instance);

    public object Find(string name);
}
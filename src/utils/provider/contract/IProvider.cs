namespace  AthenaSigner.src.utils.provider.contract;

public interface IProvider
{
    public void Add(string name, object instance);

    public object find(string name);
}
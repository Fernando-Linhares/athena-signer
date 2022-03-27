namespace AthenaSigner.Source.Utils.Provider;

using System.Collections.Generic;
using AthenaSigner.Source.Utils.Provider.Contract;

public class Provider : IProvider
{
    private Dictionary<string, object> _dependencies = new Dictionary<string, object>();
 
    public void Add(string name, object instance)
    {
        Dictionary<string, object> dependency = new Dictionary<string, object>();

        dependency.Add(name, instance);   
    }

    public object Find(string name)
    {
        return _dependencies[name];
    }
}
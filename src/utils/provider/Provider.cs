using System;
using System.Collections.Generic;
using AthenaSigner.src.utils.provider.contract;
using System.Linq;

namespace AthenaSigner.src.utils.provider;

public class Provider : IProvider
{
    private Dictionary<string, object> _dependencies = new Dictionary<string, object>();
 
    public void Add(string name, object instance)
    {
        Dictionary<string, object> dependency = new Dictionary<string, object>();

        dependency.Add(name, instance);   
    }

    public object find(string name)
    {
        return _dependencies[name];
    }
}
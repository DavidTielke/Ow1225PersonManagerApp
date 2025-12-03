using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuration.Contract;

namespace Configuration
{
    public class Configurator : IConfigurator
    {
        private readonly ConcurrentDictionary<string, ConcurrentDictionary<string, object>> _store =
            new();

        public TItem Get<TItem>(string category, string key)
        {
            if (_store.TryGetValue(category, out var categoryDict) &&
                categoryDict.TryGetValue(key, out var value) &&
                value is TItem typedValue)
            {
                return typedValue;
            }
            throw new KeyNotFoundException($"No value found for category '{category}' and key '{key}'.");
        }

        public void Set(string category, string key, object value)
        {
            var categoryDict = _store.GetOrAdd(category, _ => new ConcurrentDictionary<string, object>());
            categoryDict[key] = value;
        }
    }
}

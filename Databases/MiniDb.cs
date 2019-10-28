using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstAdaTask.Databases
{
    public class MiniDb
    {
        private readonly Dictionary<string, object> _dictionaryContainer;

        public MiniDb()
        {
            _dictionaryContainer = new Dictionary<string, object>();
        }
        
        public enum PredefinedKeys
        {
            Name
        }

        public object GetValue(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(nameof(key));
            }
            
            return _dictionaryContainer.TryGetValue(key, out object value) ? value : null;
        }

        public object GetValue(PredefinedKeys predefinedKey)
        {
            return GetValue(predefinedKey.ToString());
        }

        public void SetValue(string key, object value)
        {
            if (_dictionaryContainer.ContainsKey(key))
            {
                _dictionaryContainer[key] = value;
                return;
            }

            _dictionaryContainer.Add(key, value);
        }

        public override string ToString()
        {
            return _dictionaryContainer.Aggregate(string.Empty, (current, pair) => current + $"{pair.Key} = {pair.Value} | ");
        }

        public void SetValue(PredefinedKeys key, object value)
        {
            SetValue(key.ToString(), value);
        }
    }
}
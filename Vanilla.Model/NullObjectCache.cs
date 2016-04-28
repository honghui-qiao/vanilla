using System;

namespace Vanilla.Model
{
    public class NullObjectCache : ICacheStorage
    {
        public void Remove(string key)
        {
            // Do nothing
        }

        public void Insert(string key, object data)
        {
            // Do nothing
        }

        public T Get<T>(string key)
        {
            return default(T);
        }
    }
}

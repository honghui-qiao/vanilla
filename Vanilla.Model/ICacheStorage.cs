using System;

namespace Vanilla.Model
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Insert(string key, object data);
        T Get<T>(string key);
    }
}

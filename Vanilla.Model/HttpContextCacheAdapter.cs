using System;
using System.Web;

namespace Vanilla.Model
{
    public class HttpContextCacheAdapter : ICacheStorage
    {
        public void Remove(string key)
        {
            HttpContext.Current.Cache.Remove(key);
        }

        public void Insert(string key, object data)
        {
            HttpContext.Current.Cache.Insert(key, data);
        }

        public T Get<T>(string key)
        {
            T item = (T)HttpContext.Current.Cache.Get(key);
            if (item == null)
            {
                return default(T);
            }
            return item;
        }
    }
}

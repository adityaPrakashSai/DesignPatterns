using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface ICacheStorage
    {
        void Remove(string key);
        void Store<T>(string key, T data);
        T Retrieve<T>(string key);
    }
}

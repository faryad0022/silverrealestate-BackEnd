using System.Collections.Generic;

namespace RealEstateUI.Contract
{
    public interface ILocalStorageService
    {
        void CleareStorage(List<string> keys);
        T GetStorageValue<T>(string key);
        void SetStorageValue<T>(string key, T value);
        bool Exist(string key);
    }
}

using Hanssens.Net;
using RealEstateUI.Contract;
using System.Collections.Generic;

namespace RealEstateUI.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storage;
        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "WeChsell"
            };
            _storage = new LocalStorage(config);
        }
        public void CleareStorage(List<string> keys)
        {
            foreach (var item in keys)
            {
                _storage.Remove(item);
            }
        }

        public bool Exist(string key)
        {
            return _storage.Exists(key);
        }

        public T GetStorageValue<T>(string key)
        {
            return _storage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}

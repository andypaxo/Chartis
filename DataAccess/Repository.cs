using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Alchemy.DataAccess
{
    public static class Repository
    {
        private static Dictionary<Type, Store> stores = new Dictionary<Type,Store>();

        public static void AddStore(Type modelType)
        {
            stores.Add(modelType, new Store(modelType));
        }

        public static T Save<T>(T model)
            where T : Entity
        {
            stores[typeof(T)].Save(model);
            return model;
        }

        public static IEnumerable<T> GetEvery<T>()
            where T : Entity
        {
            var store = stores[typeof(T)];
            return from object x in store.GetAll() select (T)x;
        }

        public static T Get<T>(long id)
            where T : Entity
        {
            var store = stores[typeof(T)];
            return store.GetAll().Cast<T>().FirstOrDefault(x => ((T)x).Id == id);
        }

        private class Store
        {
            private Type modelType;
            ArrayList models = new ArrayList();
            long lastUsedId = 0;

            public Store(Type modelType)
            {
                this.modelType = modelType;
            }

            public void Save(Entity model)
            {
                if (model.Id == 0)
                    model.Id = ++lastUsedId;
                if (!models.Contains(model))
                    models.Add(model);
            }

            public IList GetAll()
            {
                return models.ToArray();
            }
        }
    }
}
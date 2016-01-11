using System.Collections.Generic;

namespace PatternCollection.Repository.Interfaces
{
    public interface IRepository<TModel, TKey>
    {
        void Save(TModel model);

        TModel Get(TKey id);

        void Update(TModel model);

        void Delete(TModel model);
    }
}

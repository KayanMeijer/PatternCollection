using System.Collections.Generic;

namespace PatternCollection.Repository.Interfaces
{
    public interface IRepository<TModel, TKey>
    {
        void Add(TModel model);

        TModel Get(TKey id);

        IEnumerable<TModel> GetAll();

        void Update(TModel model);

        void Delete(TModel model);
    }
}

using System.Collections.Generic;

namespace BookStore.Models.Repositories
{
    public interface IBookstoreRepository<TEntity>
    {
        IReadOnlyList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}

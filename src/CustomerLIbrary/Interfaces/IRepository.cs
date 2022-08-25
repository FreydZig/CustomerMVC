using System.Collections.Generic;

namespace CustomerLIbrary.Interfaces
{
    public interface IRepository<TEntity>
    {
        void Create(TEntity entity);

        TEntity Read(string entityCode);

        void Update(TEntity entity);

        void Delete(string entityCode);
        
        List<TEntity> GetAll(string customerId);
    }
}

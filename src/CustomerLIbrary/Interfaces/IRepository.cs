namespace CustomerLIbrary.Interfaces
{
    interface IRepository<TEntity>
    {
        void Create(TEntity entity);

        TEntity Read(string entityCode);

        void Update(TEntity entity);

        void Delete(string entityCode);
    }
}

namespace FinancialTamkeen_BlogAPI.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public T GetById(int id);
        public IList<T> GetAll();
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}

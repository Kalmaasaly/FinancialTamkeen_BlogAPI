using FinancialTamkeen_BlogAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FinancialTamkeen_BlogAPI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public void Create(T entity)
        {
            _db.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            _context.SaveChanges();
        }

        public IList<T> GetAll()
        {
           return _db.ToList<T>();
        }

        public T GetById(int id)
        {

            return _db.Find(id);
           
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

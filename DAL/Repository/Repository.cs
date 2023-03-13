using DAL.Context;
using DAL.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbSet<T> _entities;
        private readonly ApplicationContext _context;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return this._entities.AsEnumerable().ToList();
        }

        public T Get(string id)
        {
            return this._entities.SingleOrDefault(entity => entity.Id == id)!;
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                return; // throw exception - incorrect usage
            }

            this._entities.Add(entity);
            this._context.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

using DAL.Entities.BaseEntity;
using System.Linq.Expressions;

namespace DAL.Repository
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
        T Get(string id, Expression<Func<T, object>>? include = null);
        void Insert(T entity);
        void Delete(T entity);
        //void Update(T entity);
    }
}

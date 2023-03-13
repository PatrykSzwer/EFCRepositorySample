using DAL.Entities.BaseEntity;

namespace DAL.Repository
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
        T Get(string id);
        void Insert(T entity);
        void Delete(T entity);
        //void Update(T entity);
    }
}

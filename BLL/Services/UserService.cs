using BLL.Services.IServices;
using DAL.Entities;
using DAL.Repository;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public void CreateNewUser(string firstName, string lastName, string email)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                return;
            }

            _repository.Insert(new User { Email = email, FirstName = firstName, LastName = lastName });
        }
    }
}

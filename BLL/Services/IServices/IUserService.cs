namespace BLL.Services.IServices
{
    public interface IUserService
    {
        void CreateNewUser(string firstName, string lastName, string email);
    }
}

using Entites;

namespace Repository
{
    public interface IRepositoryUser
    {
        User Adduser(User user);
        User Getuserbyid(int id);
        User login(string UserName, string Password);
        void updateUser(int id, User value);
    }
}
using Entites;

namespace Service
{
    public interface Iserviceuser
    {
        User Adduser(User user);
        User Getuserbyid(int id);
        User login(string username, string password);
        void updateUser(int id, User value);
        int checkpassword(string password);
    }
}
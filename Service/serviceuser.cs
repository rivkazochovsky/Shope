using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Entites;
using System.Text.Json;
using Zxcvbn;

namespace Service
{

    public class serviceuser : Iserviceuser
    {
       

        //string filePath = "M:\\Api\\Shope\\Shope\\TextFile.txt";
       IRepositoryUser repository ;

        public serviceuser(IRepositoryUser _repository)
        {
            repository = _repository;
          
        }
      
        public User Getuserbyid(int id)
        {
            return repository.Getuserbyid(id);
        }
        public User Adduser(User user)
        {
            int paasswordlength = checkpassword(user.Password);
                if (paasswordlength >= 2)
                return repository.Adduser(user);
                else
                return null;
            
            
        }
       
        public User login(string username, string password)
        {
           return repository.login(username, password);
        }
        public void updateUser(int id, User value)
        {

            repository.updateUser(id, value);

        }
        public int checkpassword(string password)
        {
           
            var result = Zxcvbn.Core.EvaluatePassword(password);
            return result.Score;

        }
    }
}
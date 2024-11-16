using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager
    {
        Repository<User> repoUser = new Repository<User>();

        public User ValidateUser(string email, string password)
        {
            return repoUser.List().FirstOrDefault(u => u.UserMail == email && u.UserPassword == password);
            
        }
    }
}
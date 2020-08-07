using Swagger_DotNetCore_Model_Api.Models;
using System.Collections.Generic;

namespace Swagger_DotNetCore_Model_Api.Services
{
    public class UserService
    {
        static List<UserModel> users = new List<UserModel>
        {
             new UserModel
                {
                    Id=1,
                    Name="Pedro",
                    Email="pedro@email.com"
                },
                new UserModel
                {
                    Id=2,
                    Name="Ígor",
                    Email="igor@email.com"
                },
                new UserModel
                {
                    Id=3,
                    Name="Júlia",
                    Email="julia@email.com"
                }
        };

        public List<UserModel> Select()
        {
            return users;
        }

        public UserModel Select(int id)
        {
            return users.Find(user => user.Id == id);
        }

        public UserModel Insert(UserModel user)
        {
            return user;
        }

        public UserModel Update(int id, UserModel user)
        {
            return user;
        }

        public void Delete(int id)
        {

        }
    }
}

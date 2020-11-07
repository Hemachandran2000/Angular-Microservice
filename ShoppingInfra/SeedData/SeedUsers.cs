using ShoppingCartEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingInfra
{
    public class SeedUsers
    {
        public IEnumerable<UserModel> _users = null;
        public SeedUsers()
        {
            _users = new List<UserModel>() 
            {
                new UserModel {
                    UserId = Guid.NewGuid(),
                    UserName = "Hemanth",
                    UserPassword = "12345",
                    UserRole = "user"
                },
                new UserModel {
                    UserId = Guid.NewGuid(),
                    UserName = "Admin",
                    UserPassword = "12345",
                    UserRole = "admin"
                }
            };
        }
    }
}

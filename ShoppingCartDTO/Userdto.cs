using System;

namespace ShoppingCartDTO
{
    public class Userdto
    {       
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRole { get; set; } 
    }
}

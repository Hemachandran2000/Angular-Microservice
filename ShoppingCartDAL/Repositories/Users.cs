using System;
using System.Collections.Generic;
using ShoppingCartDTO;
using System.Text;
using ShoppingCartDAL.Interface;
using ShoppingInfra;

namespace ShoppingCartDAL.Repositories
{
    public class Users: ShoppingCart<Userdto>
    {        
        public Users(AppDbContext context): base(context)
        {
        }       
    }
}

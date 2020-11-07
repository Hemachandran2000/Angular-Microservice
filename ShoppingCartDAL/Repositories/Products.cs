using ShoppingCartDAL.Interface;
using System;
using System.Collections.Generic;
using ShoppingCartDTO;
using System.Text;
using ShoppingInfra;

namespace ShoppingCartDAL.Repositories
{
    public class Products : ShoppingCart<Productsdto>
    {        
        public Products(AppDbContext context): base(context)
        {
        }
    }
}

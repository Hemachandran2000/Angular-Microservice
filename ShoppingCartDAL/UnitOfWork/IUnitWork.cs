using ShoppingCartDAL.Interface;
using ShoppingCartDAL.Repositories;
using ShoppingCartDTO;
using ShoppingCartEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartDAL.UnitOfWork
{
    public interface IUnitWork
    {
        IShoppingCart<CategoryModel> CategoryRepo { get; }
        IShoppingCart<SubCategoryModel> SubCategoryRepo { get; }
        IShoppingCart<Productsdto> ProductsRepo { get; } 
        IShoppingCart<Userdto> UsersRepo { get; }
    }
}

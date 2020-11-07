using ShoppingCartDAL.Interface;
using ShoppingCartDAL.Repositories;
using ShoppingCartDTO;
using ShoppingCartEntity;
using ShoppingInfra;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartDAL.UnitOfWork
{
    public class UnitWork : IUnitWork
    {
        public AppDbContext Context { get; }
        public UnitWork(AppDbContext context)
        {
            Context = context;
        }
        private IShoppingCart<Productsdto> _ProductsRepo = null;
        public IShoppingCart<Productsdto> ProductsRepo 
        {
            get
            {
                if (_ProductsRepo == null)
                    _ProductsRepo = new Products(Context);

                return _ProductsRepo;
            }
        }

        private IShoppingCart<Userdto> _UsersRepo = null;
        public IShoppingCart<Userdto> UsersRepo 
        {
            get
            {
                if (_UsersRepo == null)
                    _UsersRepo = new Users(Context);

                return _UsersRepo;
            }
        }

        private IShoppingCart<CategoryModel> _CategoryRepo = null;
        public IShoppingCart<CategoryModel> CategoryRepo
        {
            get
            {
                if (_CategoryRepo == null)
                    _CategoryRepo = new Category(Context);

                return _CategoryRepo;
            }
        }

        private IShoppingCart<SubCategoryModel> _SubCategoryRepo = null;
        public IShoppingCart<SubCategoryModel> SubCategoryRepo
        {
            get
            {
                if (_SubCategoryRepo == null)
                    _SubCategoryRepo = new SubCategory(Context);

                return _SubCategoryRepo;
            }
        }
    }
}

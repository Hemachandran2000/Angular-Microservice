using ShoppingCartDTO;
using ShoppingCartEntity;
using ShoppingInfra;

namespace ShoppingCartDAL.Repositories
{
    public class Category : ShoppingCart<CategoryModel>
    {
        public Category(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

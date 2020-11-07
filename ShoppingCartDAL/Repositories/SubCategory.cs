using ShoppingCartDTO;
using ShoppingCartEntity;
using ShoppingInfra;

namespace ShoppingCartDAL.Repositories
{
    public class SubCategory : ShoppingCart<SubCategoryModel>
    {
        public SubCategory(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}

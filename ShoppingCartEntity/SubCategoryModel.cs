using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartEntity
{
    public class SubCategoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SubCategoryId { get; set; }
        public string CategoryId { get; set; }
        public string SubCategoryName { get; set; }        
        public string SubCategoryDesc { get; set; }
    }
}

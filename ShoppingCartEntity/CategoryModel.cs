using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCartEntity
{
    public class CategoryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }        
    }
}

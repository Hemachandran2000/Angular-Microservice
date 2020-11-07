using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCartEntity
{ 
    public class ProductsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrize { get; set; }
        public int ProductSize { get; set; }
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }

        public string ProductColor { get; set; }
    }
}

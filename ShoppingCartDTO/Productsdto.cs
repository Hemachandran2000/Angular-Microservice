using System;

namespace ShoppingCartDTO
{
    public class Productsdto
    {        
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrize { get; set; }
        public int ProductSize { get; set; }
        public string ProductDesc { get; set; }
        public string ProductImage { get; set; }

        public string ProductColor { get; set; }
    }
}

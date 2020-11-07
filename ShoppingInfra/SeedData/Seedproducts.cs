using ShoppingCartEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingInfra
{
    public class Seedproducts
    {
        public IEnumerable<ProductsModel> _products = null;
        string desc = "Lorem Ipsum is simply dummy text of the printing and typesetting industry."
                    + "Lorem Ipsum has been the industry's standard dummy text ever since. When an "
                    + "unknown printer took a galley.";
        public Seedproducts()
        {
            _products = new List<ProductsModel>()
            {
                new ProductsModel {
                    ProductId = Guid.NewGuid(),
                    ProductName = "Woman Fashion",
                    ProductPrize = 234,
                    ProductSize = 18,
                    ProductDesc = desc,
                    ProductImage = "assets/images/bag_5.png",
                    ProductColor = "0xFFFB7883"
                },
                new ProductsModel {
                    ProductId = Guid.NewGuid(),
                    ProductName = "New Fashion",
                    ProductPrize = 165,
                    ProductSize = 10,
                    ProductDesc = desc,
                    ProductImage = "assets/images/bag_4.png",
                    ProductColor = "0xFFAEAEAE"
                },
                new ProductsModel {
                    ProductId = Guid.NewGuid(),
                    ProductName = "Old Fashion",
                    ProductPrize = 186,
                    ProductSize = 14,
                    ProductDesc = desc,
                    ProductImage = "assets/images/bag_3.png",
                    ProductColor = "0xFFE6B398"
                },
                new ProductsModel {
                    ProductId = Guid.NewGuid(),
                    ProductName = "Office Code",
                    ProductPrize = 135,
                    ProductSize = 12,
                    ProductDesc = desc,
                    ProductImage = "assets/images/bag_2.png",
                    ProductColor = "0xFF3D82AE"
                },
                new ProductsModel {
                    ProductId = Guid.NewGuid(),
                    ProductName = "Belt Bag",
                    ProductPrize = 100,
                    ProductSize = 17,
                    ProductDesc = desc,
                    ProductImage = "assets/images/bag_1.png",
                    ProductColor = "0xFFD3A984"
                }
            };
        }
    }
}

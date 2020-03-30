using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Model.ResponseModel
{
    class ProductModel
    {
    }


    public class ProductDetail
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productImgUrl { get; set; }
        public List<ProductDetailimageUrl> imageUrl { get; set; }
        public decimal? productPrice { get; set; }
        public string productDetail { get; set; }
    }

    public class ProductDetailimageUrl
    {
        public string imageUrl { get; set; }
    }

    public class SearchProduct
    {
        public int productId { get; set; }
        public string productImgUrl { get; set; }
        public string productName { get; set; }
        public decimal? productUprice { get; set; }
        public int? productHot { get; set; }
        public int? productCommentNum { get; set; }
        public string shopName { get; set; }
    }
}

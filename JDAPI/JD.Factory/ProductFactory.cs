using JD.IService;
using JD.Model.ReceiveModel;
using JD.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Factory
{
    public class ProductFactory
    {
        #region Identity
        IProductService _iProductService;
        IProductImageService _iProductImageService;
        public ProductFactory(IProductService productService, IProductImageService productImageService)
        {
            this._iProductService = productService;
            this._iProductImageService = productImageService;
        }
        #endregion

        public ProductDetail GetProductImage(int productId)
        {
            ProductDetail model = new ProductDetail();
            var product = this._iProductService.GetById(productId);
            if (product == null)
                return model;
            model.imageUrl = ProductImageInfo(productId);
            model.productImgUrl = product.ProductImgUrl;
            model.productId = product.Id;
            model.productName = product.ProductName;
            model.productPrice = product.ProductPrice;
            model.productDetail = product.ProductDetail;
            return model;
        }

        public List<ProductDetailimageUrl> ProductImageInfo(int productId)
        {
            List<ProductDetailimageUrl> list = new List<ProductDetailimageUrl>();
            ProductDetailimageUrl model = null;
            var info = this._iProductImageService.GetByIds().Where(r => r.ProductId == productId).ToList();
            foreach (var item in info)
            {
                model = new ProductDetailimageUrl();
                model.imageUrl = item.ImageUrl;
                list.Add(model);
            }
            return list;
        }
    }
}

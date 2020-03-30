using JD.Entity.Entity;
using JD.IService;
using JD.Model.ReceiveModel;
using JD.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Service
{
    public class ProductService : AbstractService<T_Product>, IProductService
    {
        public List<SearchProduct> GetSearchProduct(SearchKey key)
        {
            return SqlHelper.Instance.Queryable<T_Product, T_Shop>((p, s) => (p.ShopId == s.ShopId))
                  .Select((p, s) => new SearchProduct
                  {
                      productId = p.Id,
                      productImgUrl = p.ProductImgUrl,
                      productName = p.ProductName,
                      productUprice = p.ProductUprice,
                      productHot = p.ProductHot,
                      productCommentNum = p.ProductCommentNum,
                      shopName = s.ShopName
                  }).OrderBy(r => r.productHot).OrderBy(r => r.productUprice).ToList();
        }
    }
}

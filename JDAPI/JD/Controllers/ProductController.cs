using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JD.Entity.Entity;
using JD.Factory;
using JD.IService;
using JD.Model.ReceiveModel;
using JD.Model.ResponseModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using JD.Service.Base;

namespace JD.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Identity
        IProductService _iProductService;
        ProductFactory _productFactory;
        public ProductController(IProductService productService, ProductFactory productFactory)
        {
            this._iProductService = productService;
            this._productFactory = productFactory;
        }
        #endregion

        [HttpPost]
        public List<T_Product> GetProduct()
        {
            return this._iProductService.GetByIds();
        }

        [HttpPost]
        public string GetProductDetail(ProductImageModel productid)
        {
            return JsonConvert.SerializeObject(this._productFactory.GetProductImage(productid.Product_id));
        }

        [HttpPost]
        public List<SearchProduct> GetSearchProduct(SearchKey key)
        {
            return this._iProductService.GetSearchProduct(key);
        }
    }
}
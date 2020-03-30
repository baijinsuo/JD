using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JD.Entity.Entity;
using JD.IService;
using JD.Model.ReceiveModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JD.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("CorsPolicy")] 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Identity
        ICategoryService _iCategoryService;
        IProductService _iProductService;
        public CategoryController(ICategoryService categoryService, IProductService productService)
        {
            this._iCategoryService = categoryService;
            this._iProductService = productService;
        }
        #endregion

        [HttpGet]
        public List<T_Category> GetCategory()
        {
            return this._iCategoryService.GetByIds();
        }

        [HttpPost]
        public List<T_Product> GetCategoryList(CategoryModel category)
        {
            return this._iProductService.GetByIds().Where(r => r.CategoryId == category.categoryId).ToList();
        }

    }
}
using JD.Entity.Entity;
using JD.IService.Base;
using JD.Model.ReceiveModel;
using JD.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.IService
{
    public interface IProductService:IBaseService<T_Product>
    {
        List<SearchProduct> GetSearchProduct(SearchKey key);
    }
}

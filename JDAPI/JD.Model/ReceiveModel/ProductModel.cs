using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.Model.ReceiveModel
{
    public class ProductModel
    {

    }

    public class SearchKey
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string productName { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal productUprice { get; set; } = 0;
        /// <summary>
        /// 销量
        /// </summary>
        public int productHot { get; set; } = 0;
        public string shopName { get; set; }
    }


}

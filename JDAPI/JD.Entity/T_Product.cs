using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Product:BaseModel
    {
        public int? CategoryId { get; set; }

        public int? ShopId { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; }

        public decimal? ProductPrice { get; set; }

        [StringLength(400)]
        public string ProductImgUrl { get; set; }

        public decimal? ProductUprice { get; set; }

        [StringLength(100)]
        public string ProductNum { get; set; }

        public string ProductDetail { get; set; }

        public int? ProductCommentNum { get; set; }

        public int? ProductHot { get; set; }

        public int? ProductSpecial { get; set; }

        public int? ProductSearchHot { get; set; }
    }
}

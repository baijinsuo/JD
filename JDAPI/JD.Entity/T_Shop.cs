using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Shop
    {
        [Key]
        public int ShopId { get; set; }

        [StringLength(200)]
        public string ShopName { get; set; }

        [StringLength(400)]
        public string ShopAddress { get; set; }

        public int? CategoryId { get; set; }
    }
}

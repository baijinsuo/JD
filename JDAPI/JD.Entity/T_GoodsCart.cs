using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_GoodsCart
    {
        [Key]
        public int CartId { get; set; }

        public int? UserId { get; set; }

        public int? ProductId { get; set; }

        public int? GoodsNum { get; set; }

        [StringLength(200)]
        public string Created { get; set; }

        public bool? Deleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_ProductImage:BaseModel
    {
        public int? ProductId { get; set; }

        [StringLength(400)]
        public string ImageUrl { get; set; }
    }
}

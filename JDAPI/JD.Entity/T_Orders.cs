using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int? ProductId { get; set; }

        public decimal? Price { get; set; }

        public int? Ocount { get; set; }

        public decimal? TotalPrice { get; set; }

        public int? UserId { get; set; }

        public int? AddressId { get; set; }

        public int? CartId { get; set; }

        public int? Stauts { get; set; }

        [StringLength(11)]
        public string Flag { get; set; }

        [StringLength(200)]
        public string BuidTime { get; set; }

        [StringLength(200)]
        public string Orderno { get; set; }
    }
}

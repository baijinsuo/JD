using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Address
    {
        public partial class Address
        {
            public int AddressId { get; set; }

            public int UserId { get; set; }

            [StringLength(400)]
            public string AddressInfo { get; set; }

            [StringLength(11)]
            public string IsDefault { get; set; }

            [StringLength(20)]
            public string UserPhone { get; set; }

            [StringLength(400)]
            public string AddressArea { get; set; }

            [StringLength(200)]
            public string Sname { get; set; }

            [StringLength(36)]
            public string Id { get; set; }
        }
    }
}

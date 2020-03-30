using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Ccollect
    {
        [Key]
        public int CollectId { get; set; }

        public int? ProductId { get; set; }

        public int? UserId { get; set; }
    }
}

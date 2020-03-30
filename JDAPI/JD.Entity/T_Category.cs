using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_Category:BaseModel
    {
        public int? CategoryPid { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }
    }
}

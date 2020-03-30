using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_LhgCity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(2)]
        public string Fename { get; set; }

        [StringLength(40)]
        public string Ename { get; set; }

        public int Pid { get; set; }

        public int Level { get; set; }

        public int Region { get; set; }

        [StringLength(50)]
        public string Map_x { get; set; }

        [StringLength(50)]
        public string Map_y { get; set; }

        [StringLength(5)]
        public string Map_z { get; set; }

        public bool Orders { get; set; }

        public int Status { get; set; }

        public int Istop { get; set; }

        public int CityId { get; set; }

        public int CityArea { get; set; }
    }
}

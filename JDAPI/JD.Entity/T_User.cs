using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JD.Entity.Entity
{
    public class T_User:BaseModel
    {
        public string UserName { get; set; }

        public string LoginName { get; set; }

        public string LoginPassword { get; set; }

        public string PayPassword { get; set; }

        public string UserPhoto { get; set; }

        public string VerificationCode { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? EditTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airtel1.Models
{
    public class Users
    {
        [Key]
        public string Pno { get; set; }

        public string name { get; set; }

        public string password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Airtel1.Models
{
    public class RoamingPlan
    {
        [Key]
        public int Rid { get; set; }

        public string validity { get; set; }

        public int Amt { get; set; }
        //[Column(TypeName = "varchar(MAX)")]
        public string Descrip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Retailer
    {
        [Key]
        public int RID { get; set; }
        public int AID { get; set; }

        public string Rname { get; set; }
        public string username { get; set; }

        public string Password { get; set; }
    }
}

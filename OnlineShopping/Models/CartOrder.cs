using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class CartOrder
    {
        [Key]
        public int COID { get; set; }
        public int UID { get; set; }

        public int PID { get; set; }

        public int Quantity { get; set; }
        public float Cost { get; set; }
    }
}

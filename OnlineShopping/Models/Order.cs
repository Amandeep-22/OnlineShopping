using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Order
    {
        [Key]
        public int OID { get; set; }
        public int UID { get; set; }
        public int COID { get; set; }

        public float TPrice { get; set; }

        public string SAddress { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

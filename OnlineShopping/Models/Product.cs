using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Product
    {
        [Key]
        public int PID { get; set; }
        public string PName { get; set; }
        public string PDetail { get; set; }

        public float Price { get; set; }

        public string PImage { get; set; }
        public int CID { get; set; }
        public int PQnt { get; set; }
        public bool IsAvailable { get; set; }
    }
}

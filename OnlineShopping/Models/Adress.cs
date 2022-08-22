using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public int UID { get; set; }

        public string Address { get; set; }

    }
}

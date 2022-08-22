using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Image
    {
        [Key]
        public int IID { get; set; }

        public string Title { get; set; }
        public string Photo { get; set; }

        public int PID { get; set; }
    }
}

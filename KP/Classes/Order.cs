using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Classes;

namespace KP.Classes
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }
        public double? Price { get; set; }
        public virtual Client Client {get;set;}
        public virtual Worker Worker { get; set; }
        public virtual Material Material { get; set; }
        public virtual Boxes Boxes { get; set; }
        public virtual Services Services { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        public DateTime EndTime { get; set; }
        [Required]
        public double Price { get; set; }
        public virtual Client Client {get;set;}
        public virtual Worker Worker { get; set; }
        public virtual ICollection<CompletedMaterial> CompletedMaterials { get; set; }
        public virtual ICollection<OrderComposition> OrderCompositions { get; set; }

    }
}

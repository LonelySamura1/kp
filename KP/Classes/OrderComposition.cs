using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class OrderComposition
    {
        [Key]
        public int OrderCompositionID { get; set; }
        [Required]
        public Services Service { get; set; }
        [Required]
        public Order Order { get; set; }
        [Required]
        public Boxes Box { get; set; }
    }
}

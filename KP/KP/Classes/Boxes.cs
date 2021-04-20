using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Classes;

namespace KP.Classes
{
    public class Boxes
    {
        [Key]
        public int BoxID { get; set; }
        [Required]
        public string BoxType { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}

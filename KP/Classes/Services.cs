using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class Services
    {
        [Key]
        public int ServiceID { get; set; }
        [Required]
        public string ServiceName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }
        [Required]
        public string MaterialName { get; set; }
        [Required]
        public string MaterialType { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

using KP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string AutoMark { get; set; }
        [Required]
        public string AutoYear { get; set; }
        [Required]
        public string VINCode { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

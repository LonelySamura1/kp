using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }
        [Required]
        public string DetailName { get; set; }
        [Required]
        public string DetailType { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual ICollection<CompletedMaterial> CompletedMaterials { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Classes
{
    public class CompletedMaterial
    {
        [Key]
        public int CompletedMaterialID { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Detail Detail { get; set; }
        public virtual Material Material { get; set; }
        public virtual Order Order { get; set; }
    }
}

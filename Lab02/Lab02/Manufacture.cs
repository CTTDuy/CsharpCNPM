using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    [Table"Manufacture"]
    class Manufacture
    {
        [Key]
        public string id { get; set; }
        [Required]
        [StringLength(128, MinimumLength = 3)]
        public string name { get; set; }
        public string location { get; set; }
        public string employee { get; set; }
        public virtual ICollection<Phone> phones { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Access
{
    public class Role
    {
        [Key]
        public byte Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; } 
    }
}

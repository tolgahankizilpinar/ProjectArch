using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.SysProj
{
    public class Parameter
    {
        [Key]
        public short Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Value { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

    }
}

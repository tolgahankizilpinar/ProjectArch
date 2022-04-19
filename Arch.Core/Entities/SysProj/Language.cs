using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.SysProj
{
    public class Language
    {
        [Key]
        public byte Id { get; set; }
        [StringLength(10)]
        public string Culture { get; set; }
        [StringLength(10)]
        public string UiCulture { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

    }
}

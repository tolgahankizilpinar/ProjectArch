using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.SysProj
{
    public class Resource : BaseEntity
    {
        public byte LanguageId { get; set; }
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(500)]
        public string Title { get; set; }

    }
}

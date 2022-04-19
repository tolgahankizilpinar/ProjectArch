using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Common
{
    public class Unit : BaseEntity
    {
        public int? ParentId { get; set; }
        public short UnitTypeId { get; set; } 
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        public bool IsActive { get; set; }


    }
}

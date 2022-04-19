using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Access
{
    public class Permission
    {
        [Key]
        public short Id { get; set; }
        public short? ParentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Controller { get; set; }
        [StringLength(50)]
        public string Action { get; set; }
        [StringLength(150)]
        public string RawUrl { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        public short? DisplayOrder { get; set; }
        public bool IsMenu { get; set; }
        public bool IsVisible { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

    }
}

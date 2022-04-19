using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Access
{
    public class RolePermission: BaseEntity
    {
      
        public byte RoleId { get; set; }
        public short PermissionId { get; set; } 
    }
}

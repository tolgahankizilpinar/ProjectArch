using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Common
{
    public class Person : BaseEntity
    {
        public int UnitId { get; set; }
        public int UserId { get; set; }
        public int MediaId { get; set; }
        public short GenderTypeId { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal? Phone { get; set; }
        [StringLength(7)]
        public string Color { get; set; }
    }
}

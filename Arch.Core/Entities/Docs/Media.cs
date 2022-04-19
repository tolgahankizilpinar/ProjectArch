using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Docs
{
    public class Media : BaseEntity
    {
        public short MediaTypeId { get; set; }
        public byte[] BinaryData { get; set; }
        [StringLength(250)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        [StringLength(50)]
        public string LengthShortName { get; set; }
        public bool IsPublic { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}

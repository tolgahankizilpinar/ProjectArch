﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Core.Entities.Access
{
    public class User : BaseEntity
    {
        [StringLength(3)]
        public string Initials { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(300)]
        public string Password { get; set; }
        public byte FailedLoginCount { get; set; }
        public DateTime? BlockedTime { get; set; }
        [StringLength(50)]
        public string BlockedIp { get; set; }
        public bool IsActive { get; set; }
        public bool IsBlock { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}

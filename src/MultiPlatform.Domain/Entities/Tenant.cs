using MultiPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Domain.Entities
{
    public class Tenant :AuditableEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Identifier { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}

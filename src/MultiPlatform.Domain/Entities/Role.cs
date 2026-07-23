using MultiPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPlatform.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public Guid TenantId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Tenant Tenant { get; set; } = null!;
        public ICollection<User> Users { get; set; } = new List<User>();

        public ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    }
}

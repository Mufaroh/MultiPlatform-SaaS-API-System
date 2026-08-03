using MultiPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPlatform.Domain.Enums

namespace MultiPlatform.Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid TenantId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public UserStatus Status { get; set; } = UserStatus.Pending;


        public Tenant Tenant { get; set; } = null!;
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}

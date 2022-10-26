using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Right
    {
        public Right()
        {
            IdPermissions = new HashSet<Permission>();
            Idroles = new HashSet<Role>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Permission> IdPermissions { get; set; }
        public virtual ICollection<Role> Idroles { get; set; }
    }
}

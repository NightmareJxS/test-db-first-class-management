using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Permission
    {
        public Permission()
        {
            IdRights = new HashSet<Right>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Right> IdRights { get; set; }
    }
}

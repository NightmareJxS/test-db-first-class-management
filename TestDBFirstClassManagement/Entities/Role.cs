using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
            Idrights = new HashSet<Right>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Right> Idrights { get; set; }
    }
}

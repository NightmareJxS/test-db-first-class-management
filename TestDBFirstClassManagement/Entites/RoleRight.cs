using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class RoleRight
    {
        public long IdRight { get; set; }
        public long IdRole { get; set; }

        public virtual Right IdRightNavigation { get; set; } = null!;
        public virtual Role IdRoleNavigation { get; set; } = null!;
    }
}

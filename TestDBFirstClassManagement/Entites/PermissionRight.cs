using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class PermissionRight
    {
        public long IdRight { get; set; }
        public long IdPermission { get; set; }

        public virtual Permission IdPermissionNavigation { get; set; } = null!;
        public virtual Right IdRightNavigation { get; set; } = null!;
    }
}

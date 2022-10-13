using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Permission
    {
        public long IdPermission { get; set; }
        public string PermissionName { get; set; } = null!;
    }
}

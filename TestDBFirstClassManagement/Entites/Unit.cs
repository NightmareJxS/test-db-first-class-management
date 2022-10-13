using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Unit
    {
        public long IdUnit { get; set; }
        public string UnitName { get; set; } = null!;
        public long IdSession { get; set; }

        public virtual Session IdSessionNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassLocation
    {
        public long IdClass { get; set; }
        public long IdLocation { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
        public virtual Location IdLocationNavigation { get; set; } = null!;
    }
}

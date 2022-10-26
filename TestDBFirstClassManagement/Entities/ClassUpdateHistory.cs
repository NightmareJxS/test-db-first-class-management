using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class ClassUpdateHistory
    {
        public long IdClass { get; set; }
        public long ModifyBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
        public virtual User ModifyByNavigation { get; set; } = null!;
    }
}

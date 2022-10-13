using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassUpdateHistory
    {
        public long ClassId { get; set; }
        public long ModifyBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual User ModifyByNavigation { get; set; } = null!;
    }
}

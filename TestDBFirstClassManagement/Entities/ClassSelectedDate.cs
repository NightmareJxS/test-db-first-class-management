using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class ClassSelectedDate
    {
        public long Id { get; set; }
        public long IdClass { get; set; }
        public DateTime ActiveDate { get; set; }
        public int Status { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
    }
}

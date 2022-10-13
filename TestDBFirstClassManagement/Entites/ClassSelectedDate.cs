using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassSelectedDate
    {
        public long IdDate { get; set; }
        public long IdClass { get; set; }
        public DateTime ActiveDate { get; set; }
        public int Status { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
    }
}

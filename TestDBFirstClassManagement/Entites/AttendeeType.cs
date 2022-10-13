using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class AttendeeType
    {
        public AttendeeType()
        {
            Classes = new HashSet<Class>();
        }

        public long IdAttendeeType { get; set; }
        public string AttendeeTypeName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

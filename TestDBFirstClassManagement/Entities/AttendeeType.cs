using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class AttendeeType
    {
        public AttendeeType()
        {
            Classes = new HashSet<Class>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

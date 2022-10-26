using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Location
    {
        public Location()
        {
            IdClasses = new HashSet<Class>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Status { get; set; }

        public virtual ICollection<Class> IdClasses { get; set; }
    }
}

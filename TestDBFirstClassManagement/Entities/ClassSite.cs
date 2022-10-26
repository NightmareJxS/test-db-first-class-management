using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class ClassSite
    {
        public ClassSite()
        {
            Classes = new HashSet<Class>();
        }

        public long Id { get; set; }
        public string Site { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

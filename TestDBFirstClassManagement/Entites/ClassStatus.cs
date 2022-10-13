using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassStatus
    {
        public ClassStatus()
        {
            Classes = new HashSet<Class>();
        }

        public long IdStatus { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

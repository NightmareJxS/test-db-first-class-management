using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassSite
    {
        public ClassSite()
        {
            Classes = new HashSet<Class>();
        }

        public long IdSite { get; set; }
        public string ClassSite1 { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassTechnicalGroup
    {
        public ClassTechnicalGroup()
        {
            Classes = new HashSet<Class>();
        }

        public long IdTechnicalGroup { get; set; }
        public string TechnicalGroupName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

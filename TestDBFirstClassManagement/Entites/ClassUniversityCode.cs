using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassUniversityCode
    {
        public ClassUniversityCode()
        {
            Classes = new HashSet<Class>();
        }

        public long IdUniversity { get; set; }
        public string? UniversityCode { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}

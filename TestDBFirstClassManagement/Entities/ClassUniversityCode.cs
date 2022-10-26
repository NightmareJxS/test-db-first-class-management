using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class ClassUniversityCode
    {
        public ClassUniversityCode()
        {
            Classes = new HashSet<Class>();
        }

        public long Id { get; set; }
        public string UniversityCode { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

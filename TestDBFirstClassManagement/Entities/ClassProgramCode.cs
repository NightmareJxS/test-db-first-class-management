using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class ClassProgramCode
    {
        public ClassProgramCode()
        {
            Classes = new HashSet<Class>();
        }

        public long Id { get; set; }
        public string ProgramCode { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

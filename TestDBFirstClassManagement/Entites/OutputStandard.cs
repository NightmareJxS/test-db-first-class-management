using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class OutputStandard
    {
        public OutputStandard()
        {
            Lessons = new HashSet<Lesson>();
        }

        public long IdOutputStandard { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

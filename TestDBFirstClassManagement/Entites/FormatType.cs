using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class FormatType
    {
        public FormatType()
        {
            Lessons = new HashSet<Lesson>();
        }

        public long IdFormatType { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

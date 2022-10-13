using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassFormatType
    {
        public ClassFormatType()
        {
            Classes = new HashSet<Class>();
        }

        public long IdFormatType { get; set; }
        public string FormatTypeName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}

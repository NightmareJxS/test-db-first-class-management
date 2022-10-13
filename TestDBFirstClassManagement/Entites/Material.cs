using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Material
    {
        public long IdMaterial { get; set; }
        public string? MaterialName { get; set; }
        public string? HyperLink { get; set; }
        public long IdLesson { get; set; }

        public virtual Lesson IdLessonNavigation { get; set; } = null!;
    }
}

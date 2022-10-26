using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Curriculum
    {
        public long IdProgram { get; set; }
        public long IdSyllabus { get; set; }
        public int NumberOrder { get; set; }

        public virtual TrainingProgram IdProgramNavigation { get; set; } = null!;
        public virtual Syllabus IdSyllabusNavigation { get; set; } = null!;
    }
}

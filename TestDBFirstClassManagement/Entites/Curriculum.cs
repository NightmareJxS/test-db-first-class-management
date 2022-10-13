using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Curriculum
    {
        public long IdProgram { get; set; }
        public long IdSyllabus { get; set; }
        public double NumberOrder { get; set; }

        public virtual TrainingProgram IdProgramNavigation { get; set; } = null!;
        public virtual Syllabuse IdSyllabusNavigation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class AssignmentSchema
    {
        public long Idsyllabus { get; set; }
        public double? PercentQuiz { get; set; }
        public double? PercentAssigment { get; set; }
        public double? PercentFinal { get; set; }
        public double? PercentTheory { get; set; }
        public double? PercentFinalPractice { get; set; }
        public double? PassingCriterial { get; set; }

        public virtual Syllabus IdsyllabusNavigation { get; set; } = null!;
    }
}

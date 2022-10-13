using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class AssignmentSchema
    {
        public long Idsyllabus { get; set; }
        public int? PercentQuiz { get; set; }
        public int? PercentAssigment { get; set; }
        public int? PercentFinal { get; set; }
        public int? PercentTheory { get; set; }
        public int? PercentFinalPractice { get; set; }
        public int? PassingCriterial { get; set; }

        public virtual Syllabuse IdsyllabusNavigation { get; set; } = null!;
    }
}

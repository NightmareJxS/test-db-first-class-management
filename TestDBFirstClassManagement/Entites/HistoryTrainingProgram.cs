using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class HistoryTrainingProgram
    {
        public long UserId { get; set; }
        public long IdProgram { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual TrainingProgram IdProgramNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class HistoryTrainingProgram
    {
        public long IdUser { get; set; }
        public long IdProgram { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual TrainingProgram IdProgramNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
    }
}

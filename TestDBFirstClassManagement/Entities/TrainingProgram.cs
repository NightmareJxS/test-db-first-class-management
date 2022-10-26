using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class TrainingProgram
    {
        public TrainingProgram()
        {
            Classes = new HashSet<Class>();
            Curricula = new HashSet<Curriculum>();
            HistoryTrainingPrograms = new HashSet<HistoryTrainingProgram>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<HistoryTrainingProgram> HistoryTrainingPrograms { get; set; }
    }
}

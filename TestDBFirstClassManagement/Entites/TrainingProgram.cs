using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class TrainingProgram
    {
        public long IdProgram { get; set; }
        public string ProgramName { get; set; } = null!;
        public int Status { get; set; }

        public virtual Class? Class { get; set; }
    }
}

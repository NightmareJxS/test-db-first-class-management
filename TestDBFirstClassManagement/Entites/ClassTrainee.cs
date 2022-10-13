using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassTrainee
    {
        public long UserId { get; set; }
        public long ClassCode { get; set; }

        public virtual Class ClassCodeNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

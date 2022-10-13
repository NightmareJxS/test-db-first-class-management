using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class HistorySyllabus
    {
        public long UserId { get; set; }
        public long IdSyllabus { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Syllabuse IdSyllabusNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

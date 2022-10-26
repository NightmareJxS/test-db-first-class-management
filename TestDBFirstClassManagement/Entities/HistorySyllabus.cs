using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class HistorySyllabus
    {
        public long IdUser { get; set; }
        public long IdSyllabus { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Action { get; set; } = null!;

        public virtual Syllabus IdSyllabusNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
    }
}

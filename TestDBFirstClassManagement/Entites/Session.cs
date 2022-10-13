using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Session
    {
        public Session()
        {
            Units = new HashSet<Unit>();
        }

        public long IdSession { get; set; }
        public string SessionName { get; set; } = null!;
        public long IdSyllabus { get; set; }

        public virtual Syllabuse IdSyllabusNavigation { get; set; } = null!;
        public virtual ICollection<Unit> Units { get; set; }
    }
}

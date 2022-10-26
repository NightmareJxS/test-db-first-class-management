using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class FsucontactPoint
    {
        public FsucontactPoint()
        {
            Classes = new HashSet<Class>();
        }

        public long Id { get; set; }
        public long IdFsu { get; set; }
        public string Contact { get; set; } = null!;
        public int Status { get; set; }

        public virtual FsoftUnit IdFsuNavigation { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}

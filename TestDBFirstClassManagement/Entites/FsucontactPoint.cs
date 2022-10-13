using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class FsucontactPoint
    {
        public FsucontactPoint()
        {
            Classes = new HashSet<Class>();
        }

        public long IdContact { get; set; }
        public long Fsuid { get; set; }
        public string Contact { get; set; } = null!;
        public int Status { get; set; }

        public virtual FsoftUnit Fsu { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}

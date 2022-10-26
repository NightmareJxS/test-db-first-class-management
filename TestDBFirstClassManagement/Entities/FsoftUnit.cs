using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class FsoftUnit
    {
        public FsoftUnit()
        {
            Classes = new HashSet<Class>();
            FsucontactPoints = new HashSet<FsucontactPoint>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<FsucontactPoint> FsucontactPoints { get; set; }
    }
}

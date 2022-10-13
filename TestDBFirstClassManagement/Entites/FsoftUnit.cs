using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class FsoftUnit
    {
        public FsoftUnit()
        {
            Classes = new HashSet<Class>();
            FsucontactPoints = new HashSet<FsucontactPoint>();
        }

        public long IdUnit { get; set; }
        public string UnitName { get; set; } = null!;
        public int Status { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<FsucontactPoint> FsucontactPoints { get; set; }
    }
}

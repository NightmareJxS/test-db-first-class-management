using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Lesson
    {
        public Lesson()
        {
            Materials = new HashSet<Material>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public long IdDeliveryType { get; set; }
        public long IdFormatType { get; set; }
        public long IdOutputStandard { get; set; }
        public long IdUnit { get; set; }

        public virtual DeliveryType IdDeliveryTypeNavigation { get; set; } = null!;
        public virtual FormatType IdFormatTypeNavigation { get; set; } = null!;
        public virtual OutputStandard IdOutputStandardNavigation { get; set; } = null!;
        public virtual Unit IdUnitNavigation { get; set; } = null!;
        public virtual ICollection<Material> Materials { get; set; }
    }
}

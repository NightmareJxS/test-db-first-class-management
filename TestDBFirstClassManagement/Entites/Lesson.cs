using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Lesson
    {
        public Lesson()
        {
            Materials = new HashSet<Material>();
        }

        public long IdLesson { get; set; }
        public string? LessonName { get; set; }
        public int? Duration { get; set; }
        public long IdDeliveryType { get; set; }
        public long IdFormatType { get; set; }
        public long IdOutputStandard { get; set; }

        public virtual DeliveryType IdDeliveryTypeNavigation { get; set; } = null!;
        public virtual FormatType IdFormatTypeNavigation { get; set; } = null!;
        public virtual OutputStandard IdOutputStandardNavigation { get; set; } = null!;
        public virtual ICollection<Material> Materials { get; set; }
    }
}

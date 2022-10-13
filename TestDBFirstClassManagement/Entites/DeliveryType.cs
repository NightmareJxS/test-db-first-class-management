using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class DeliveryType
    {
        public DeliveryType()
        {
            Lessons = new HashSet<Lesson>();
        }

        public long IdDeliveryType { get; set; }
        public string TypeName { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

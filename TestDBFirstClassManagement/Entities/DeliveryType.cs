using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class DeliveryType
    {
        public DeliveryType()
        {
            Lessons = new HashSet<Lesson>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Material
    {
        public Material()
        {
            HistoryMaterials = new HashSet<HistoryMaterial>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string HyperLink { get; set; } = null!;
        public long IdLesson { get; set; }

        public virtual Lesson IdLessonNavigation { get; set; } = null!;
        public virtual ICollection<HistoryMaterial> HistoryMaterials { get; set; }
    }
}

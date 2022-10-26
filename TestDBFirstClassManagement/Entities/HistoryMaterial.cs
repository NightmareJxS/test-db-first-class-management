using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class HistoryMaterial
    {
        public long IdUser { get; set; }
        public long IdMaterial { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Action { get; set; } = null!;

        public virtual Material IdMaterialNavigation { get; set; } = null!;
        public virtual User IdUserNavigation { get; set; } = null!;
    }
}

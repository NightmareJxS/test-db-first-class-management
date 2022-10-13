using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class HistoryMaterial
    {
        public long UserId { get; set; }
        public long IdMaterial { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Material IdMaterialNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

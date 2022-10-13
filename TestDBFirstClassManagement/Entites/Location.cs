using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Location
    {
        public long IdLocation { get; set; }
        public string LocationName { get; set; } = null!;
        public int Status { get; set; }
    }
}

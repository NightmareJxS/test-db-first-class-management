using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class User
    {
        public User()
        {
            ClassApprovedByNavigations = new HashSet<Class>();
            ClassCreatedByNavigations = new HashSet<Class>();
            ClassReviewedByNavigations = new HashSet<Class>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public byte[]? Image { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public int Status { get; set; }
        public long IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; } = null!;
        public virtual ICollection<Class> ClassApprovedByNavigations { get; set; }
        public virtual ICollection<Class> ClassCreatedByNavigations { get; set; }
        public virtual ICollection<Class> ClassReviewedByNavigations { get; set; }
    }
}

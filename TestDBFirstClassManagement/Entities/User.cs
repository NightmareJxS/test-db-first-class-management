using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class User
    {
        public User()
        {
            ClassApprovedByNavigations = new HashSet<Class>();
            ClassCreatedByNavigations = new HashSet<Class>();
            ClassReviewedByNavigations = new HashSet<Class>();
            ClassUpdateHistories = new HashSet<ClassUpdateHistory>();
            HistoryMaterials = new HashSet<HistoryMaterial>();
            HistorySyllabi = new HashSet<HistorySyllabus>();
            HistoryTrainingPrograms = new HashSet<HistoryTrainingProgram>();
            IdClasses = new HashSet<Class>();
            IdClasses1 = new HashSet<Class>();
            IdClassesNavigation = new HashSet<Class>();
            IdSyllabi = new HashSet<Syllabus>();
        }

        public long Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public byte[]? Image { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Status { get; set; }
        public long IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; } = null!;
        public virtual ICollection<Class> ClassApprovedByNavigations { get; set; }
        public virtual ICollection<Class> ClassCreatedByNavigations { get; set; }
        public virtual ICollection<Class> ClassReviewedByNavigations { get; set; }
        public virtual ICollection<ClassUpdateHistory> ClassUpdateHistories { get; set; }
        public virtual ICollection<HistoryMaterial> HistoryMaterials { get; set; }
        public virtual ICollection<HistorySyllabus> HistorySyllabi { get; set; }
        public virtual ICollection<HistoryTrainingProgram> HistoryTrainingPrograms { get; set; }

        public virtual ICollection<Class> IdClasses { get; set; }
        public virtual ICollection<Class> IdClasses1 { get; set; }
        public virtual ICollection<Class> IdClassesNavigation { get; set; }
        public virtual ICollection<Syllabus> IdSyllabi { get; set; }
    }
}

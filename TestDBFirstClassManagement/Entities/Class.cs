using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Class
    {
        public Class()
        {
            ClassSelectedDates = new HashSet<ClassSelectedDate>();
            ClassUpdateHistories = new HashSet<ClassUpdateHistory>();
            IdLocations = new HashSet<Location>();
            IdUsers = new HashSet<User>();
            IdUsers1 = new HashSet<User>();
            IdUsersNavigation = new HashSet<User>();
        }

        public long Id { get; set; }
        public string? ClassCode { get; set; }
        public string Name { get; set; } = null!;
        public int Status { get; set; }
        public TimeSpan? StartTimeLearning { get; set; }
        public TimeSpan? EndTimeLearing { get; set; }
        public long? ReviewedBy { get; set; }
        public DateTime? ReviewedOn { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? PlannedAtendee { get; set; }
        public int? ActualAttendee { get; set; }
        public int? AcceptedAttendee { get; set; }
        public int? CurrentSession { get; set; }
        public int? CurrentUnit { get; set; }
        public int? StartYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int ClassNumber { get; set; }
        public long? IdProgram { get; set; }
        public long? IdTechnicalGroup { get; set; }
        public long? IdFsu { get; set; }
        public long? IdFsucontact { get; set; }
        public long IdStatus { get; set; }
        public long? IdSite { get; set; }
        public long? IdUniversity { get; set; }
        public long? IdFormatType { get; set; }
        public long? IdProgramContent { get; set; }
        public long? IdAttendeeType { get; set; }

        public virtual User? ApprovedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual AttendeeType? IdAttendeeTypeNavigation { get; set; }
        public virtual ClassFormatType? IdFormatTypeNavigation { get; set; }
        public virtual FsoftUnit? IdFsuNavigation { get; set; }
        public virtual FsucontactPoint? IdFsucontactNavigation { get; set; }
        public virtual ClassProgramCode? IdProgramContentNavigation { get; set; }
        public virtual TrainingProgram? IdProgramNavigation { get; set; }
        public virtual ClassSite? IdSiteNavigation { get; set; }
        public virtual ClassStatus IdStatusNavigation { get; set; } = null!;
        public virtual ClassTechnicalGroup? IdTechnicalGroupNavigation { get; set; }
        public virtual ClassUniversityCode? IdUniversityNavigation { get; set; }
        public virtual User? ReviewedByNavigation { get; set; }
        public virtual ICollection<ClassSelectedDate> ClassSelectedDates { get; set; }
        public virtual ICollection<ClassUpdateHistory> ClassUpdateHistories { get; set; }

        public virtual ICollection<Location> IdLocations { get; set; }
        public virtual ICollection<User> IdUsers { get; set; }
        public virtual ICollection<User> IdUsers1 { get; set; }
        public virtual ICollection<User> IdUsersNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entities
{
    public partial class Syllabus
    {
        public Syllabus()
        {
            Curricula = new HashSet<Curriculum>();
            HistorySyllabi = new HashSet<HistorySyllabus>();
            Sessions = new HashSet<Session>();
            IdUsers = new HashSet<User>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int AttendeeNumber { get; set; }
        public double Version { get; set; }
        public string? Technicalrequirement { get; set; }
        public string? CourseObjectives { get; set; }
        public int Status { get; set; }
        public string? TrainingPrinciple { get; set; }
        public string? Description { get; set; }
        public string? HyperLink { get; set; }
        public long IdLevel { get; set; }

        public virtual Level IdLevelNavigation { get; set; } = null!;
        public virtual AssignmentSchema? AssignmentSchema { get; set; }
        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<HistorySyllabus> HistorySyllabi { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

        public virtual ICollection<User> IdUsers { get; set; }
    }
}

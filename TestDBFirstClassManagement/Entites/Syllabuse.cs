using System;
using System.Collections.Generic;

namespace TestDBFirstClassManagement.Entites
{
    public partial class Syllabuse
    {
        public Syllabuse()
        {
            Sessions = new HashSet<Session>();
        }

        public long IdSyllabus { get; set; }
        public string SyllabusName { get; set; } = null!;
        public string SyllabusCode { get; set; } = null!;
        public double Version { get; set; }
        public string? TechnicalRequirement { get; set; }
        public string? CourseObjectives { get; set; }
        public int Status { get; set; }
        public string? TrainingPrinciple { get; set; }
        public string? Description { get; set; }
        public string? HyperLink { get; set; }
        public long IdLevel { get; set; }

        public virtual Level IdLevelNavigation { get; set; } = null!;
        public virtual AssignmentSchema? AssignmentSchema { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}

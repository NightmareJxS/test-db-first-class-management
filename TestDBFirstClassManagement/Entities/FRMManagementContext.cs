using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestDBFirstClassManagement.Entities
{
    public partial class FRMManagementContext : DbContext
    {
        public FRMManagementContext()
        {
        }

        public FRMManagementContext(DbContextOptions<FRMManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssignmentSchema> AssignmentSchemas { get; set; } = null!;
        public virtual DbSet<AttendeeType> AttendeeTypes { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassFormatType> ClassFormatTypes { get; set; } = null!;
        public virtual DbSet<ClassProgramCode> ClassProgramCodes { get; set; } = null!;
        public virtual DbSet<ClassSelectedDate> ClassSelectedDates { get; set; } = null!;
        public virtual DbSet<ClassSite> ClassSites { get; set; } = null!;
        public virtual DbSet<ClassStatus> ClassStatuses { get; set; } = null!;
        public virtual DbSet<ClassTechnicalGroup> ClassTechnicalGroups { get; set; } = null!;
        public virtual DbSet<ClassUniversityCode> ClassUniversityCodes { get; set; } = null!;
        public virtual DbSet<ClassUpdateHistory> ClassUpdateHistories { get; set; } = null!;
        public virtual DbSet<Curriculum> Curricula { get; set; } = null!;
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; } = null!;
        public virtual DbSet<FormatType> FormatTypes { get; set; } = null!;
        public virtual DbSet<FsoftUnit> FsoftUnits { get; set; } = null!;
        public virtual DbSet<FsucontactPoint> FsucontactPoints { get; set; } = null!;
        public virtual DbSet<HistoryMaterial> HistoryMaterials { get; set; } = null!;
        public virtual DbSet<HistorySyllabus> HistorySyllabi { get; set; } = null!;
        public virtual DbSet<HistoryTrainingProgram> HistoryTrainingPrograms { get; set; } = null!;
        public virtual DbSet<Lesson> Lessons { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<OutputStandard> OutputStandards { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<Right> Rights { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<Syllabus> Syllabi { get; set; } = null!;
        public virtual DbSet<TrainingProgram> TrainingPrograms { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);database= FRMManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignmentSchema>(entity =>
            {
                entity.HasKey(e => e.Idsyllabus);

                entity.ToTable("assignmentSchemas");

                entity.Property(e => e.Idsyllabus)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSyllabus");

                entity.HasOne(d => d.IdsyllabusNavigation)
                    .WithOne(p => p.AssignmentSchema)
                    .HasForeignKey<AssignmentSchema>(d => d.Idsyllabus);
            });

            modelBuilder.Entity<AttendeeType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasIndex(e => e.ApprovedBy, "IX_Classes_ApprovedBy");

                entity.HasIndex(e => e.CreatedBy, "IX_Classes_CreatedBy");

                entity.HasIndex(e => e.IdAttendeeType, "IX_Classes_IdAttendeeType");

                entity.HasIndex(e => e.IdFsu, "IX_Classes_IdFSU");

                entity.HasIndex(e => e.IdFsucontact, "IX_Classes_IdFSUContact");

                entity.HasIndex(e => e.IdFormatType, "IX_Classes_IdFormatType");

                entity.HasIndex(e => e.IdProgram, "IX_Classes_IdProgram");

                entity.HasIndex(e => e.IdProgramContent, "IX_Classes_IdProgramContent");

                entity.HasIndex(e => e.IdSite, "IX_Classes_IdSite");

                entity.HasIndex(e => e.IdStatus, "IX_Classes_IdStatus");

                entity.HasIndex(e => e.IdTechnicalGroup, "IX_Classes_IdTechnicalGroup");

                entity.HasIndex(e => e.IdUniversity, "IX_Classes_IdUniversity");

                entity.HasIndex(e => e.ReviewedBy, "IX_Classes_ReviewedBy");

                entity.Property(e => e.ApprovedOn).HasColumnType("date");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdFsu).HasColumnName("IdFSU");

                entity.Property(e => e.IdFsucontact).HasColumnName("IdFSUContact");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewedOn).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.ClassApprovedByNavigations)
                    .HasForeignKey(d => d.ApprovedBy);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ClassCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.IdAttendeeTypeNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdAttendeeType);

                entity.HasOne(d => d.IdFormatTypeNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFormatType);

                entity.HasOne(d => d.IdFsuNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFsu);

                entity.HasOne(d => d.IdFsucontactNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFsucontact);

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdProgram);

                entity.HasOne(d => d.IdProgramContentNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdProgramContent);

                entity.HasOne(d => d.IdSiteNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdSite);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdStatus);

                entity.HasOne(d => d.IdTechnicalGroupNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdTechnicalGroup);

                entity.HasOne(d => d.IdUniversityNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdUniversity);

                entity.HasOne(d => d.ReviewedByNavigation)
                    .WithMany(p => p.ClassReviewedByNavigations)
                    .HasForeignKey(d => d.ReviewedBy);

                entity.HasMany(d => d.IdLocations)
                    .WithMany(p => p.IdClasses)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassLocation",
                        l => l.HasOne<Location>().WithMany().HasForeignKey("IdLocation"),
                        r => r.HasOne<Class>().WithMany().HasForeignKey("IdClass"),
                        j =>
                        {
                            j.HasKey("IdClass", "IdLocation");

                            j.ToTable("ClassLocations");

                            j.HasIndex(new[] { "IdLocation" }, "IX_ClassLocations_IdLocation");
                        });
            });

            modelBuilder.Entity<ClassFormatType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassProgramCode>(entity =>
            {
                entity.Property(e => e.ProgramCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassSelectedDate>(entity =>
            {
                entity.HasIndex(e => e.IdClass, "IX_ClassSelectedDates_IdClass");

                entity.Property(e => e.ActiveDate).HasColumnType("date");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassSelectedDates)
                    .HasForeignKey(d => d.IdClass);
            });

            modelBuilder.Entity<ClassSite>(entity =>
            {
                entity.Property(e => e.Site).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassStatus>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassTechnicalGroup>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassUniversityCode>(entity =>
            {
                entity.Property(e => e.UniversityCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ClassUpdateHistory>(entity =>
            {
                entity.HasKey(e => new { e.IdClass, e.ModifyBy });

                entity.HasIndex(e => e.ModifyBy, "IX_ClassUpdateHistories_ModifyBy");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassUpdateHistories)
                    .HasForeignKey(d => d.IdClass);

                entity.HasOne(d => d.ModifyByNavigation)
                    .WithMany(p => p.ClassUpdateHistories)
                    .HasForeignKey(d => d.ModifyBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Curriculum>(entity =>
            {
                entity.HasKey(e => new { e.IdProgram, e.IdSyllabus });

                entity.HasIndex(e => e.IdSyllabus, "IX_Curricula_IdSyllabus");

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(d => d.IdProgram);

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany(p => p.Curricula)
                    .HasForeignKey(d => d.IdSyllabus);
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FormatType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FsoftUnit>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FsucontactPoint>(entity =>
            {
                entity.ToTable("FSUContactPoints");

                entity.HasIndex(e => e.IdFsu, "IX_FSUContactPoints_IdFSU");

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.IdFsu).HasColumnName("IdFSU");

                entity.HasOne(d => d.IdFsuNavigation)
                    .WithMany(p => p.FsucontactPoints)
                    .HasForeignKey(d => d.IdFsu);
            });

            modelBuilder.Entity<HistoryMaterial>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdMaterial, e.ModifiedOn });

                entity.HasIndex(e => e.IdMaterial, "IX_HistoryMaterials_IdMaterial");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.HistoryMaterials)
                    .HasForeignKey(d => d.IdMaterial);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.HistoryMaterials)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<HistorySyllabus>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdSyllabus, e.ModifiedOn });

                entity.HasIndex(e => e.IdSyllabus, "IX_HistorySyllabi_IdSyllabus");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany(p => p.HistorySyllabi)
                    .HasForeignKey(d => d.IdSyllabus);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.HistorySyllabi)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<HistoryTrainingProgram>(entity =>
            {
                entity.HasKey(e => new { e.IdUser, e.IdProgram });

                entity.HasIndex(e => e.IdProgram, "IX_HistoryTrainingPrograms_IdProgram");

                entity.Property(e => e.ModifiedOn).HasColumnType("date");

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithMany(p => p.HistoryTrainingPrograms)
                    .HasForeignKey(d => d.IdProgram);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.HistoryTrainingPrograms)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasIndex(e => e.IdDeliveryType, "IX_Lessons_IdDeliveryType");

                entity.HasIndex(e => e.IdFormatType, "IX_Lessons_IdFormatType");

                entity.HasIndex(e => e.IdOutputStandard, "IX_Lessons_IdOutputStandard");

                entity.HasIndex(e => e.IdUnit, "IX_Lessons_IdUnit");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdDeliveryTypeNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdDeliveryType);

                entity.HasOne(d => d.IdFormatTypeNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdFormatType);

                entity.HasOne(d => d.IdOutputStandardNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdOutputStandard);

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdUnit);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasIndex(e => e.IdLesson, "IX_Materials_IdLesson");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdLessonNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.IdLesson);
            });

            modelBuilder.Entity<OutputStandard>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasMany(d => d.IdPermissions)
                    .WithMany(p => p.IdRights)
                    .UsingEntity<Dictionary<string, object>>(
                        "PermissionRight",
                        l => l.HasOne<Permission>().WithMany().HasForeignKey("IdPermission"),
                        r => r.HasOne<Right>().WithMany().HasForeignKey("IdRight"),
                        j =>
                        {
                            j.HasKey("IdRight", "IdPermission");

                            j.ToTable("PermissionRights");

                            j.HasIndex(new[] { "IdPermission" }, "IX_PermissionRights_IdPermission");
                        });

                entity.HasMany(d => d.Idroles)
                    .WithMany(p => p.Idrights)
                    .UsingEntity<Dictionary<string, object>>(
                        "RoleRight",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("Idrole"),
                        r => r.HasOne<Right>().WithMany().HasForeignKey("Idright"),
                        j =>
                        {
                            j.HasKey("Idright", "Idrole");

                            j.ToTable("RoleRights");

                            j.HasIndex(new[] { "Idrole" }, "IX_RoleRights_IDRole");

                            j.IndexerProperty<long>("Idright").HasColumnName("IDRight");

                            j.IndexerProperty<long>("Idrole").HasColumnName("IDRole");
                        });
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasIndex(e => e.IdSyllabus, "IX_Sessions_IdSyllabus");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.IdSyllabus);
            });

            modelBuilder.Entity<Syllabus>(entity =>
            {
                entity.HasIndex(e => e.IdLevel, "IX_Syllabi_IdLevel");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Technicalrequirement).HasColumnType("ntext");

                entity.Property(e => e.TrainingPrinciple).HasColumnType("ntext");

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Syllabi)
                    .HasForeignKey(d => d.IdLevel);
            });

            modelBuilder.Entity<TrainingProgram>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasIndex(e => e.IdSession, "IX_Units_IdSession");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdSessionNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.IdSession);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.IdRole, "IX_Users_IdRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole);

                entity.HasMany(d => d.IdClasses)
                    .WithMany(p => p.IdUsers)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassAdmin",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("IdClass"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("IdUser").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("IdUser", "IdClass");

                            j.ToTable("ClassAdmins");

                            j.HasIndex(new[] { "IdClass" }, "IX_ClassAdmins_IdClass");
                        });

                entity.HasMany(d => d.IdClasses1)
                    .WithMany(p => p.IdUsers1)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassTrainee",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("IdClass"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("IdUser").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("IdUser", "IdClass");

                            j.ToTable("ClassTrainees");

                            j.HasIndex(new[] { "IdClass" }, "IX_ClassTrainees_IdClass");
                        });

                entity.HasMany(d => d.IdClassesNavigation)
                    .WithMany(p => p.IdUsersNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "ClassMentor",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("IdClass"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("IdUser").OnDelete(DeleteBehavior.ClientSetNull),
                        j =>
                        {
                            j.HasKey("IdUser", "IdClass");

                            j.ToTable("classMentors");

                            j.HasIndex(new[] { "IdClass" }, "IX_classMentors_IdClass");
                        });

                entity.HasMany(d => d.IdSyllabi)
                    .WithMany(p => p.IdUsers)
                    .UsingEntity<Dictionary<string, object>>(
                        "SyllabusTrainer",
                        l => l.HasOne<Syllabus>().WithMany().HasForeignKey("IdSyllabus"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("IdUser"),
                        j =>
                        {
                            j.HasKey("IdUser", "IdSyllabus");

                            j.ToTable("SyllabusTrainers");

                            j.HasIndex(new[] { "IdSyllabus" }, "IX_SyllabusTrainers_IdSyllabus");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

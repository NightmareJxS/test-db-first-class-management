using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestDBFirstClassManagement.Entites
{
    public partial class ClassManagementContext : DbContext
    {
        public ClassManagementContext()
        {
        }

        public ClassManagementContext(DbContextOptions<ClassManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssignmentSchema> AssignmentSchemas { get; set; } = null!;
        public virtual DbSet<AttendeeType> AttendeeTypes { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassAdmin> ClassAdmins { get; set; } = null!;
        public virtual DbSet<ClassFormatType> ClassFormatTypes { get; set; } = null!;
        public virtual DbSet<ClassLocation> ClassLocations { get; set; } = null!;
        public virtual DbSet<ClassMentor> ClassMentors { get; set; } = null!;
        public virtual DbSet<ClassProgramCode> ClassProgramCodes { get; set; } = null!;
        public virtual DbSet<ClassSelectedDate> ClassSelectedDates { get; set; } = null!;
        public virtual DbSet<ClassSite> ClassSites { get; set; } = null!;
        public virtual DbSet<ClassStatus> ClassStatuses { get; set; } = null!;
        public virtual DbSet<ClassTechnicalGroup> ClassTechnicalGroups { get; set; } = null!;
        public virtual DbSet<ClassTrainee> ClassTrainees { get; set; } = null!;
        public virtual DbSet<ClassUniversityCode> ClassUniversityCodes { get; set; } = null!;
        public virtual DbSet<ClassUpdateHistory> ClassUpdateHistories { get; set; } = null!;
        public virtual DbSet<Curriculum> Curriculums { get; set; } = null!;
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
        public virtual DbSet<PermissionRight> PermissionRights { get; set; } = null!;
        public virtual DbSet<Right> Rights { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleRight> RoleRights { get; set; } = null!;
        public virtual DbSet<Session> Sessions { get; set; } = null!;
        public virtual DbSet<SyllabusTrainer> SyllabusTrainers { get; set; } = null!;
        public virtual DbSet<Syllabuse> Syllabuses { get; set; } = null!;
        public virtual DbSet<TrainingProgram> TrainingPrograms { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);database= ClassManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignmentSchema>(entity =>
            {
                entity.HasKey(e => e.Idsyllabus)
                    .HasName("PK__Assignme__930997CB2467E112");

                entity.ToTable("AssignmentSchema");

                entity.Property(e => e.Idsyllabus)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSyllabus");

                entity.HasOne(d => d.IdsyllabusNavigation)
                    .WithOne(p => p.AssignmentSchema)
                    .HasForeignKey<AssignmentSchema>(d => d.Idsyllabus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Syllabus_AssignmentSchema");
            });

            modelBuilder.Entity<AttendeeType>(entity =>
            {
                entity.HasKey(e => e.IdAttendeeType)
                    .HasName("PK__Attendee__96482FBCD64BFAEA");

                entity.ToTable("AttendeeType");

                entity.Property(e => e.AttendeeTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.IdClass)
                    .HasName("PK__Classes__003FCC7DC39CF188");

                entity.HasIndex(e => e.IdProgram, "UQ__Classes__415673D11B853B0B")
                    .IsUnique();

                entity.Property(e => e.ApprovedOn).HasColumnType("date");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdFsu).HasColumnName("IdFSU");

                entity.Property(e => e.IdFsucontact).HasColumnName("IdFSUContact");

                entity.Property(e => e.ReviewedOn).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.ClassApprovedByNavigations)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK__Classes__Approve__4CA06362");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ClassCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Classes__Created__4BAC3F29");

                entity.HasOne(d => d.IdAttendeeTypeNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdAttendeeType)
                    .HasConstraintName("FK__Classes__IdAtten__5629CD9C");

                entity.HasOne(d => d.IdFormatTypeNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFormatType)
                    .HasConstraintName("FK__Classes__IdForma__5441852A");

                entity.HasOne(d => d.IdFsuNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFsu)
                    .HasConstraintName("FK__Classes__IdFSU__4F7CD00D");

                entity.HasOne(d => d.IdFsucontactNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdFsucontact)
                    .HasConstraintName("FK__Classes__IdFSUCo__5070F446");

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithOne(p => p.Class)
                    .HasForeignKey<Class>(d => d.IdProgram)
                    .HasConstraintName("FK__Classes__IdProgr__4D94879B");

                entity.HasOne(d => d.IdProgramContentNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdProgramContent)
                    .HasConstraintName("FK__Classes__IdProgr__5535A963");

                entity.HasOne(d => d.IdSiteNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdSite)
                    .HasConstraintName("FK__Classes__IdSite__52593CB8");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Classes__IdStatu__5165187F");

                entity.HasOne(d => d.IdUniversityNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdUniversity)
                    .HasConstraintName("FK__Classes__IdUnive__534D60F1");

                entity.HasOne(d => d.ReviewedByNavigation)
                    .WithMany(p => p.ClassReviewedByNavigations)
                    .HasForeignKey(d => d.ReviewedBy)
                    .HasConstraintName("FK__Classes__Reviewe__4AB81AF0");

                entity.HasOne(d => d.TechnicalGroupNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.TechnicalGroup)
                    .HasConstraintName("FK__Classes__Technic__4E88ABD4");
            });

            modelBuilder.Entity<ClassAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ClassCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassAdmi__Class__60A75C0F");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassAdmi__UserI__5FB337D6");
            });

            modelBuilder.Entity<ClassFormatType>(entity =>
            {
                entity.HasKey(e => e.IdFormatType)
                    .HasName("PK__ClassFor__232CFF212926EAF0");

                entity.ToTable("ClassFormatType");

                entity.Property(e => e.FormatTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassLocation>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassLoca__IdCla__5CD6CB2B");

                entity.HasOne(d => d.IdLocationNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassLoca__IdLoc__5DCAEF64");
            });

            modelBuilder.Entity<ClassMentor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ClassCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassMent__Class__6383C8BA");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassMent__UserI__628FA481");
            });

            modelBuilder.Entity<ClassProgramCode>(entity =>
            {
                entity.HasKey(e => e.IdClassProgramCode)
                    .HasName("PK__ClassPro__B14F7F3615A8081E");

                entity.ToTable("ClassProgramCode");

                entity.Property(e => e.ProgramCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassSelectedDate>(entity =>
            {
                entity.HasKey(e => e.IdDate)
                    .HasName("PK__ClassSel__F298CC89777CB066");

                entity.ToTable("ClassSelectedDate");

                entity.Property(e => e.ActiveDate).HasColumnType("date");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassSelectedDates)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassSele__IdCla__59063A47");
            });

            modelBuilder.Entity<ClassSite>(entity =>
            {
                entity.HasKey(e => e.IdSite)
                    .HasName("PK__ClassSit__A683AE6977AD0F5D");

                entity.Property(e => e.ClassSite1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClassSite");
            });

            modelBuilder.Entity<ClassStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__ClassSta__B450643AD811F729");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassTechnicalGroup>(entity =>
            {
                entity.HasKey(e => e.IdTechnicalGroup)
                    .HasName("PK__ClassTec__3F89888BC16038F7");

                entity.Property(e => e.TechnicalGroupName).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassTrainee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClassTrainee");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ClassCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ClassCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassTrai__Class__66603565");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassTrai__UserI__656C112C");
            });

            modelBuilder.Entity<ClassUniversityCode>(entity =>
            {
                entity.HasKey(e => e.IdUniversity)
                    .HasName("PK__ClassUni__8DC53EDA12FDE072");

                entity.ToTable("ClassUniversityCode");

                entity.Property(e => e.UniversityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassUpdateHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClassUpdateHistory");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Class)
                    .WithMany()
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassUpda__Class__68487DD7");

                entity.HasOne(d => d.ModifyByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ModifyBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClassUpda__Modif__693CA210");
            });

            modelBuilder.Entity<Curriculum>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProgram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Curriculu__IdPro__72C60C4A");

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSyllabus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Curriculu__IdSyl__73BA3083");
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.HasKey(e => e.IdDeliveryType)
                    .HasName("PK__Delivery__D0D4288F30111950");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<FormatType>(entity =>
            {
                entity.HasKey(e => e.IdFormatType)
                    .HasName("PK__FormatTy__232CFF219A232AA1");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<FsoftUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnit)
                    .HasName("PK__FsoftUni__B6938BBE4133DF0C");

                entity.ToTable("FsoftUnit");

                entity.Property(e => e.UnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<FsucontactPoint>(entity =>
            {
                entity.HasKey(e => e.IdContact)
                    .HasName("PK__FSUConta__2AC556F6382D9C90");

                entity.ToTable("FSUContactPoint");

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.Fsuid).HasColumnName("FSUId");

                entity.HasOne(d => d.Fsu)
                    .WithMany(p => p.FsucontactPoints)
                    .HasForeignKey(d => d.Fsuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FSUContac__FSUId__3B75D760");
            });

            modelBuilder.Entity<HistoryMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ModifiedOn).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistoryMa__IdMat__0F624AF8");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistoryMa__UserI__0E6E26BF");
            });

            modelBuilder.Entity<HistorySyllabus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HistorySyllabus");

                entity.Property(e => e.ModifiedOn).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSyllabus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistorySy__IdSyl__70DDC3D8");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistorySy__UserI__6FE99F9F");
            });

            modelBuilder.Entity<HistoryTrainingProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HistoryTrainingProgram");

                entity.Property(e => e.ModifiedOn).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdProgramNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProgram)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistoryTr__IdPro__34C8D9D1");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HistoryTr__UserI__33D4B598");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.IdLesson)
                    .HasName("PK__Lessons__2253D85A2DC21572");

                entity.Property(e => e.LessonName).HasMaxLength(50);

                entity.HasOne(d => d.IdDeliveryTypeNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdDeliveryType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lessons__IdDeliv__07C12930");

                entity.HasOne(d => d.IdFormatTypeNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdFormatType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lessons__IdForma__08B54D69");

                entity.HasOne(d => d.IdOutputStandardNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.IdOutputStandard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lessons__IdOutpu__09A971A2");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.IdLevel)
                    .HasName("PK__Levels__A4740DB4AD0022A8");

                entity.Property(e => e.LevelName).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.IdLocation)
                    .HasName("PK__Location__FB5FABA9F4BCBEF3");

                entity.Property(e => e.LocationName).HasMaxLength(100);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.IdMaterial)
                    .HasName("PK__Material__94356E58303CF4D6");

                entity.Property(e => e.MaterialName).HasMaxLength(50);

                entity.HasOne(d => d.IdLessonNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.IdLesson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materials__IdLes__0C85DE4D");
            });

            modelBuilder.Entity<OutputStandard>(entity =>
            {
                entity.HasKey(e => e.IdOutputStandard)
                    .HasName("PK__OutputSt__66EF52722187984B");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.IdPermission)
                    .HasName("PK__Permissi__17C26EA24257EA97");

                entity.Property(e => e.PermissionName).HasMaxLength(50);
            });

            modelBuilder.Entity<PermissionRight>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdPermissionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPermission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permissio__IdPer__2D27B809");

                entity.HasOne(d => d.IdRightNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Permissio__IdRig__2C3393D0");
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.HasKey(e => e.IdRight)
                    .HasName("PK__Rights__75AA73809BBF8A31");

                entity.Property(e => e.RightName).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Roles__B4369054BD486F8E");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<RoleRight>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdRightNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoleRight__IdRig__29572725");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RoleRight__IdRol__2A4B4B5E");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.IdSession)
                    .HasName("PK__Session__A3483377919A2E69");

                entity.ToTable("Session");

                entity.Property(e => e.SessionName).HasMaxLength(50);

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.IdSyllabus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Session__IdSylla__7C4F7684");
            });

            modelBuilder.Entity<SyllabusTrainer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.IdSyllabusNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSyllabus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SyllabusT__IdSyl__76969D2E");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SyllabusT__UserI__75A278F5");
            });

            modelBuilder.Entity<Syllabuse>(entity =>
            {
                entity.HasKey(e => e.IdSyllabus)
                    .HasName("PK__Syllabus__C7B23F793F2CAD73");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.SyllabusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyllabusName).HasMaxLength(50);

                entity.Property(e => e.TechnicalRequirement).HasColumnType("ntext");

                entity.Property(e => e.TrainingPrinciple).HasColumnType("ntext");

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Syllabuses)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Syllabuse__IdLev__6E01572D");
            });

            modelBuilder.Entity<TrainingProgram>(entity =>
            {
                entity.HasKey(e => e.IdProgram)
                    .HasName("PK__Training__415673D09A808F43");

                entity.Property(e => e.ProgramName).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.IdUnit)
                    .HasName("PK__Units__B6938BBE3D2D3C7D");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.HasOne(d => d.IdSessionNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.IdSession)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Units__IdSession__7F2BE32F");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

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

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__IdRole__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

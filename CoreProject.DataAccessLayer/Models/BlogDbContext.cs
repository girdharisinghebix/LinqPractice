using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.DataAccessLayer.Models;

public partial class BlogDbContext : DbContext
{
    public BlogDbContext()
    {
    }

    public BlogDbContext(DbContextOptions<BlogDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PracAttemptMark> PracAttemptMarks { get; set; }

    public virtual DbSet<PracSubMark> PracSubMarks { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentAddressDetail> StudentAddressDetails { get; set; }

    public virtual DbSet<StudentCourseM> StudentCourseMs { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<Table2> Table2s { get; set; }

    public virtual DbSet<ThAttemptMark> ThAttemptMarks { get; set; }

    public virtual DbSet<ThSubMark> ThSubMarks { get; set; }

    public virtual DbSet<TransferCustomer> TransferCustomers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-BPAQI80A;Database=BlogDB;Trusted_Connection=True;Trusted_Connection=True;\nTrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC272769D8A4");

            entity.ToTable("Category");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Slug)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SLUG");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D71A71E5DC2E2");

            entity.ToTable("Course");

            entity.Property(e => e.CourseName).IsUnicode(false);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__Post__63FD176616B9E9CC");

            entity.ToTable("Post");

            entity.Property(e => e.PostId).HasColumnName("POST_ID");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Title)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("TITLE");

            entity.HasOne(d => d.Category).WithMany(p => p.Posts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Post__CATEGORY_I__38996AB5");
        });

        modelBuilder.Entity<PracAttemptMark>(entity =>
        {
            entity.HasKey(e => e.AttemptMarksId).HasName("PK__PracAtte__76CC0D4A3BE0555A");

            entity.HasOne(d => d.PracSubMark).WithMany(p => p.PracAttemptMarks)
                .HasForeignKey(d => d.PracSubMarkId)
                .HasConstraintName("FK__PracAttem__PracS__398D8EEE");
        });

        modelBuilder.Entity<PracSubMark>(entity =>
        {
            entity.HasKey(e => e.PracSubMarkId).HasName("PK__PracSubM__DFFBDE547DCD3C52");

            entity.ToTable("PracSubMark");

            entity.HasOne(d => d.Subject).WithMany(p => p.PracSubMarks)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__PracSubMa__Subje__29221CFB");
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.SemesterId).HasName("PK__Semester__043301DDC2CCEE1D");

            entity.ToTable("Semester");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SemesterName).IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Semesters)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Semester__Course__2A164134");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B997A713506");

            entity.ToTable("Student");

            entity.Property(e => e.FatherName).IsUnicode(false);
            entity.Property(e => e.MotherName).IsUnicode(false);
            entity.Property(e => e.StudentName).IsUnicode(false);
        });

        modelBuilder.Entity<StudentAddressDetail>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__StudentA__091C2AFB71768FF9");

            entity.ToTable("StudentAddressDetail");

            entity.Property(e => e.AddressId).ValueGeneratedNever();
            entity.Property(e => e.AddressDetail)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentAddressDetails)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__StudentAd__Stude__3C34F16F");
        });

        modelBuilder.Entity<StudentCourseM>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentC__3214EC273CFB35C2");

            entity.ToTable("StudentCourse_M");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourseMs)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__StudentCo__Cours__2B0A656D");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourseMs)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__StudentCo__Stude__2BFE89A6");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__AC1BA3A8283F4E37");

            entity.ToTable("Subject");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SubjectName).IsUnicode(false);

            entity.HasOne(d => d.Semester).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.SemesterId)
                .HasConstraintName("FK__Subject__Semeste__2CF2ADDF");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Table2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ThAttemptMark>(entity =>
        {
            entity.HasKey(e => e.AttemptMarksId).HasName("PK__ThAttemp__76CC0D4A9174B839");

            entity.Property(e => e.AttemptMarksId).ValueGeneratedNever();

            entity.HasOne(d => d.ThSubMark).WithMany(p => p.ThAttemptMarks)
                .HasForeignKey(d => d.ThSubMarkId)
                .HasConstraintName("FK__ThAttempt__ThSub__2DE6D218");
        });

        modelBuilder.Entity<ThSubMark>(entity =>
        {
            entity.HasKey(e => e.ThSubMarkId).HasName("PK__ThSubMar__9334A8EA1015BE1B");

            entity.ToTable("ThSubMark");

            entity.HasOne(d => d.Subject).WithMany(p => p.ThSubMarks)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__ThSubMark__Subje__2EDAF651");
        });

        modelBuilder.Entity<TransferCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TransferCustomerData");

            entity.ToTable("TransferCustomer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Password).IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

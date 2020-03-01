using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarsityPortal.Models;

namespace VarsityPortal.Data
{
    public class VarsityContext : IdentityDbContext 
    {
        public VarsityContext(DbContextOptions<VarsityContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Enrollment>()
                .HasKey(bc => new { bc.SectionId, bc.StudentId });
            
            builder.Entity<Enrollment>()
                .HasOne(bc => bc.Section)
                .WithMany(b => b.Enrollments)
                .HasForeignKey(bc => bc.SectionId)
                .OnDelete(DeleteBehavior.Restrict); 
            
            builder.Entity<Enrollment>()
                .HasOne(bc => bc.Student)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(bc => bc.StudentId);

            builder.Entity<Course>()
                .HasOne(c => c.Department)
                .WithMany(d => d.Courses)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Sections> Sections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}

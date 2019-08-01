using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<Exam_Questions> exam_Questions { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<StdsAnswer> stdsAnswers { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Track> tracks { get; set; }
        public DbSet<Type> types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam_Questions>()
                .HasKey(c => new { c.Que_Id, c.Ex_Id });
            modelBuilder.Entity<StdsAnswer>()
              .HasKey(c => new { c.Que_Id, c.Ex_Id });
        }
      
    }
}

using Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = Common.Entities.Task;

namespace Common.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<UserToProject> UserToProjects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Worklog> Worklogs { get; set; }

        public MyDbContext()
        {
            this.Users = this.Set<User>();
            this.Projects = this.Set<Project>();
            this.Tasks = this.Set<Task>();
            this.UserToProjects = this.Set<UserToProject>();
            this.Comments = this.Set<Comment>();
            this.Worklogs = this.Set<Worklog>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjectDB;User Id=steliyanaB;Password=steli123456789;")
                          .UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User()
            {
                Id = 1,
                Username = "admin",
                Password = "admin123456789",
                FirstName = "Steliyana",
                LastName = "Brezalieva",
                Email = "steli06@abv.bg",
                Phone = "0874861526",
                Address = "Devin, Bulgaria"

            });
        }
    }
}

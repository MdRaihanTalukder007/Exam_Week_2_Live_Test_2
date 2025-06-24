using Exam_Week_2_Live_Test_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Exam_Week_2_Live_Test_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<StudentResult> StudentResults { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedingData(builder);
        }

        private void SeedingData(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin" }, new Role() { Id = 2, Name = "Manager" }, new Role() { Id = 3, Name = "Salesman" }
                );

            User user1 = new User()
            {
                Id = 1,
                FirstName = "Md. Raihan",
                LastName = "Talukder",
                RoleId = 1,
            };

            User user2 = new User()
            {
                Id = 2,
                FirstName = "Rohan",
                LastName = "Kibria",
                RoleId = 2,
            };

            User user3 = new User()
            {
                Id = 3,
                FirstName = "Razib",
                LastName = "Chowdhuri",
                RoleId = 3,
            };

            builder.Entity<User>().HasData(user1,user2,user3);


        }
    }
}

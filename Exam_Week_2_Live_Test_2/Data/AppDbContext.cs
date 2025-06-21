using Exam_Week_2_Live_Test_2.Models;
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
    }
}

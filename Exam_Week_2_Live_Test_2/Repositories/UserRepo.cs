using Exam_Week_2_Live_Test_2.Data;
using Exam_Week_2_Live_Test_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam_Week_2_Live_Test_2.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext context;

        public UserRepo(AppDbContext context)
        {
            this.context = context;
        }

        public List<User> GetAll()
        {
            return this.context.Users.Include(u => u.Role).AsNoTracking().ToList();
        }

        public List<Role> GetAllRoles()
        {
            return this.context.Roles.AsNoTracking().ToList();
        }
    }
}

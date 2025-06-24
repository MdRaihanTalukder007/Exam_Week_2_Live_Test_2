using Exam_Week_2_Live_Test_2.Models;

namespace Exam_Week_2_Live_Test_2.Repositories
{
    public interface IUserRepo
    {
        List<User> GetAll();
        List<Role> GetAllRoles();
    }
}

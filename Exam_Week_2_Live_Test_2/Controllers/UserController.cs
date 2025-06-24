using Exam_Week_2_Live_Test_2.Models;
using Exam_Week_2_Live_Test_2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Exam_Week_2_Live_Test_2.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }

        public IActionResult Index(int? roleId)
        {
            var users = this._userRepo.GetAll();
            if (roleId.HasValue && roleId.Value > 0) {
                users = users.Where(u => u.RoleId == roleId).ToList();
            }
            ViewBag.Roles = new SelectList(this._userRepo.GetAllRoles(), "Id", "Name");

            return View(users);
        }
    }
}

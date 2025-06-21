using Exam_Week_2_Live_Test_2.Data;
using Exam_Week_2_Live_Test_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam_Week_2_Live_Test_2.Controllers
{
    public class StudentResultsController : Controller
    {
        private readonly AppDbContext _context;
        public StudentResultsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(ResultStatus? status)
        {
            List<StudentResultViewModel> stdResultList = new List<StudentResultViewModel>();
            var results = _context.StudentResults.AsNoTracking();
            if (results != null)
            {
                foreach (var item in results)
                {
                    StudentResultViewModel stdResult = new StudentResultViewModel();
                    stdResult.Id = item.Id;
                    stdResult.StudentName = item.StudentName;
                    stdResult.CourseTitle = item.CourseTitle;
                    stdResult.TotalMarks = item.TotalMarks;
                    stdResultList.Add(stdResult);
                }
            }

            ViewBag.SelectedStatus = status;

            if (status.HasValue)
            {
                stdResultList = stdResultList.Where(r => r.Status == status.Value).ToList();
            }

            return View(stdResultList.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentResult model)
        {
            if (ModelState.IsValid)
            {
                _context.StudentResults.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}

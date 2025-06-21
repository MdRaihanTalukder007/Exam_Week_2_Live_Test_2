using System.ComponentModel.DataAnnotations;

namespace Exam_Week_2_Live_Test_2.Models
{
    public class StudentResult
    {
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string CourseTitle { get; set; }

        [Range(0, 100)]
        public int TotalMarks { get; set; }

        public ResultStatus Status
        {
            get
            {
                if (TotalMarks < 50) return ResultStatus.NeedsImprovement;
                if (TotalMarks <= 80) return ResultStatus.Good;
                return ResultStatus.Excellent;
            }
        }
    }

    public enum ResultStatus
    {
        NeedsImprovement,
        Good,
        Excellent
    }
}

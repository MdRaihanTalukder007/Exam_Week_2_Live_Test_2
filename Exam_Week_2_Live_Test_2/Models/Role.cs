
using System.ComponentModel.DataAnnotations;

namespace Exam_Week_2_Live_Test_2.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

}

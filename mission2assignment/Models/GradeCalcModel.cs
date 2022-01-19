using System;
using System.ComponentModel.DataAnnotations;

namespace mission2assignment.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0,100)]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public int GroupProjects { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quizes { get; set; }
        [Required]
        [Range(0, 100)]
        public int Exams { get; set; }
        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}

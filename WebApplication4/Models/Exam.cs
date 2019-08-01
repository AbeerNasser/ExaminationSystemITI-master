using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Exam
    {
        [Key]
        public int Exam_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ex_Name { get; set; }

        public int? Time { get; set; }

        public int? Sub_Id { get; set; }

        public virtual ICollection<Exam_Questions> Exam_Questions { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual ICollection<StdsAnswer> StdsAnswers { get; set; }
    }
}

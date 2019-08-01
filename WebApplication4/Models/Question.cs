using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Que_Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(5)]
        public string Type { get; set; }

        public string Answers_Options { get; set; }

        public string Correct_Answers { get; set; }

        [StringLength(20)]
        public string Image { get; set; }

        public virtual ICollection<Exam_Questions> Exam_Questions { get; set; }

        public virtual Type Type1 { get; set; }
        public virtual ICollection<StdsAnswer> StdsAnswers { get; set; }
    }
}

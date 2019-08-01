using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class StdsAnswer
    {
        [Column(Order = 0), Key, ForeignKey("Question")]

        public int Que_Id { get; set; }

        [Column(Order = 1), Key, ForeignKey("Exam")]

        public int Ex_Id { get; set; }

        [Column(Order = 2), Key, ForeignKey("Instructor")]

        public int Std_Id { get; set; }

        [Required]
        public string Choose_Answer { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }

        public virtual Student Student { get; set; }
    }
}

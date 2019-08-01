using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Exam_Questions
    {
        [Column(Order = 0), Key, ForeignKey("Exam")]
        public int Ex_Id { get; set; }

        [Column(Order = 1), Key, ForeignKey("Question")]
        public int Que_Id { get; set; }

        public int Degree { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Question Question { get; set; }
    }
}

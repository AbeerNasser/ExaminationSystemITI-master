using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Subject
    {
        [Key]
        public int Sub_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sub_Name { get; set; }
        [ForeignKey("Track")]
        public int Track_Id { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual Track Track { get; set; }


        
    }
}

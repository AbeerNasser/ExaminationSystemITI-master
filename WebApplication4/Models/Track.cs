using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Trs_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Trs_Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Sub_Inst
    {
        [Column(Order = 0), Key, ForeignKey("Subject")]

        public int Sub_Id { get; set; }

        [Column(Order = 1), Key, ForeignKey("Instructor")]

        public int Inst_Id { get; set; }
        public Subject subject { get; set; }
        public Instructor instructor { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}

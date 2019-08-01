using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Instructor
    {
        [Key]
        public int Inst_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Inst_Name { get; set; }

        public int Inst_Age { get; set; }

        [StringLength(50)]
        public string Inst_Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Inst_Phone { get; set; }

        public int User_Id { get; set; }

        public int Admin_Id { get; set; }

        public int? Track_Id { get; set; }

        public virtual Track Track { get; set; }

    }
}

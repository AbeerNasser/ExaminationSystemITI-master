using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Std_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Std_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Std_Address { get; set; }

        public int Std_Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Std_Fauclty { get; set; }

        [Required]
        [StringLength(50)]
        public string Std_University { get; set; }

        public int User_Id { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        public int? Track_id { get; set; }

        public double? Degree { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public int? CreateID { get; set; }

        public int? EditID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EditDate { get; set; }

        public virtual ICollection<StdsAnswer> StdsAnswers { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}

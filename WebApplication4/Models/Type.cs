using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models
{
    public class Type
    {
        [Key]
        [StringLength(5)]
        public string Type_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MCQ { get; set; }

        public bool? True_False { get; set; }

        [MaxLength(100)]
        public byte[] Image { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccms.Data
{
    [Table("In_student_table")]
    internal class In_students
    {
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string in_student_id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string in_student_name { get; set; }
        [Required]
        [Column(TypeName = "char(5)")]
        public string in_time { get; set; }
        //public int paper_printed { get; set; }

    }
}

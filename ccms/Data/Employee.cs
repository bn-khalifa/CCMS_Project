using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccms.Data
{
    [Table("Employee_table")]
    internal class Employee
    {
        [Key]
        [Column(TypeName = "varchar(15)")]
        public string emp_id { get; set; } 
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string emp_name { get; set;}
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string emp_email { get; set;}
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string emp_password { get; set;}
        //public byte[] emp_photo { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string emp_photo_path { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ccms.Data
{
    [Table("History_table")]
    internal class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("history_id")]
        public int history_id { get; set; }
        [Column(TypeName = "char(15)")]
        public string employee_id { get; set; }
        [Column(TypeName = "char(15)")]
        public string student_id { get; set; }
        [Column(TypeName = "char(5)")]
        public string time_in { get; set; }
        [Column(TypeName = "char(5)")]
        public string time_out { get; set; }
        [Required]
        [Column(TypeName = "datetime")] 
        public DateTime date { get; set; }
        [Column(TypeName = "FLOAT(2)")]
        public double cost { get; set; }
        //public int paper_count { get; set; }
    }
}

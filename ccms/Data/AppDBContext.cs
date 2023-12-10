using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccms.Data
{
    internal class AppDBContext : DbContext
    {
        public DbSet<In_students> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<History> History_table { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { emp_id = "E001", emp_name = "John mark", emp_email = "john@example.com", emp_password = "password1", emp_photo_path = "path/photo.jpg" },
                new Employee { emp_id = "E002", emp_name = "Hossam Samy", emp_email = "hoss@example.com", emp_password = "password2", emp_photo_path = "path/photo2.jpg" },
                new Employee { emp_id = "E003", emp_name = "Ahmed Ali", emp_email = "ahmed@example.com", emp_password = "password3", emp_photo_path = "path/photo3.jpg" }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JACG8CO\\SQLEXPRESS;Initial Catalog=SWproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

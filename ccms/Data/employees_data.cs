using ccms.Data;

namespace ccms
{
    internal class EmployeesData
    {
        // Assuming this method is called somewhere to perform the data seeding
        public static void SeedEmployees()
        {
            using (AppDBContext dbContext = new AppDBContext())
            {
                var employee1 = new Employee()
                {
                    emp_id = "E001",
                    emp_name = "John mark",
                    emp_email = "john@example.com",
                    emp_password = "password1",
                    emp_photo_path = "path/photo.jpg"
                };

                var employee2 = new Employee
                {
                    emp_id = "E002",
                    emp_name = "Hossam Samy",
                    emp_email = "hoss@example.com",
                    emp_password = "password2",
                    emp_photo_path = "path/photo2.jpg"
                };

                var employee3 = new Employee
                {
                    emp_id = "E003",
                    emp_name = "Ahmed Ali",
                    emp_email = "ahmed@example.com",
                    emp_password = "password3",
                    emp_photo_path = "path/photo3.jpg"
                };

                // Add employees to the DbSet
                dbContext.Employees.AddRange(employee1, employee2, employee3);

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }
    }
}

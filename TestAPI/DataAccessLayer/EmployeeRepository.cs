using TestAPI.Entities;

namespace TestAPI.DataAccessLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> employees = new List<Employee>();

        public EmployeeRepository()
        {
            employees.Add(new Employee
            {
                Employee_id = 1,
                First_Name = "Rahul",
                Last_Name = "Sharma",
                Department = "Finance",
                Address = "Pune",
                HireDate = new DateTime(2023, 2, 15),
                Dob = new DateTime(1990, 5, 23),
                JoiningDate = new DateTime(2023, 3, 10),
                Salary = 50000
            });
            employees.Add(new Employee
            {
                Employee_id = 2,
                First_Name = "Dev",
                Last_Name = "Patel",
                Department = "Sales",
                Address = "Hyderabad",
                HireDate = new DateTime(2021, 9, 25),
                Dob = new DateTime(1988, 11, 03),
                JoiningDate = new DateTime(2021, 10, 10),
                Salary = 60000
            });
            employees.Add(new Employee
            {
                Employee_id = 3,
                First_Name = "Raj",
                Last_Name = "Sahoo",
                Department = "Sales",
                Address = "Mumbai",
                HireDate = new DateTime(2021, 11, 05),
                Dob = new DateTime(1992, 8, 14),
                JoiningDate = new DateTime(2023, 11, 25),
                Salary = 40000
            });
            employees.Add(new Employee
            {
                Employee_id = 4,
                First_Name = "Payal",
                Last_Name = "Rajput",
                Department = "IT",
                Address = "Hyderabad",
                HireDate = new DateTime(2022, 1, 10),
                Dob = new DateTime(1996, 5, 23),
                JoiningDate = new DateTime(2022, 2, 05),
                Salary = 35000
            });
            employees.Add(new Employee
            {
                Employee_id = 5,
                First_Name = "Manisha",
                Last_Name = "Dixit",
                Department = "Finance",
                Address = "Pune",
                HireDate = new DateTime(2022, 12, 15),
                Dob = new DateTime(1994, 12, 25),
                JoiningDate = new DateTime(2023, 1, 10),
                Salary = 50000
            });
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return employees.FirstOrDefault(e => e.Employee_id == employeeId);
        }
        public IEnumerable<Employee> GetEmployeesOrderByDepartment()
        {
            return employees.OrderBy(e => e.Department);
        }

        public IEnumerable<Employee> GetEmployeesOrderBySalary()
        {
            return employees.OrderByDescending(e => e.Salary);
        }
    }
}

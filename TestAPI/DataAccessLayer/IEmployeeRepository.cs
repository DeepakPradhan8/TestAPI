using TestAPI.Entities;

namespace TestAPI.DataAccessLayer
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployeeById(int employeeId);
        public IEnumerable<Employee> GetEmployeesOrderByDepartment();
        public IEnumerable<Employee> GetEmployeesOrderBySalary();
    }
}

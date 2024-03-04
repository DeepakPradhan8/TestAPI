using TestAPI.Entities;

namespace TestAPI.BuisnessLayer
{
    public interface IEmployeeService
    {
        public Employee GetEmployeeById(int employeeId);
        public IEnumerable<Employee> GetEmployeesOrderByDepartment();
        public IEnumerable<Employee> GetEmployeeOrderBySalary();
    }
}

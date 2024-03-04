using TestAPI.DataAccessLayer;
using TestAPI.Entities;

namespace TestAPI.BuisnessLayer
{
    public class EmployeeService : IEmployeeService
    {
        #region Private Property
        private readonly IEmployeeRepository _employeeRepository;
        #endregion

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _employeeRepository.GetEmployeeById(employeeId);
        }
        public IEnumerable<Employee> GetEmployeesOrderByDepartment()
        {
            return _employeeRepository.GetEmployeesOrderByDepartment();
        }
        public IEnumerable<Employee> GetEmployeeOrderBySalary()
        {
            return _employeeRepository.GetEmployeesOrderBySalary();
        }
    }
}

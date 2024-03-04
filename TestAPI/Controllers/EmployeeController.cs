using Microsoft.AspNetCore.Mvc;
using TestAPI.BuisnessLayer;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Private Property
        private readonly IEmployeeService _employeeService;
        #endregion

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        /// <summary>
        /// Getting Employee by their respective id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [HttpGet("{employeeId}")]
        public IActionResult GetEmployeeById(int employeeId)
        {
            var employee = _employeeService.GetEmployeeById(employeeId);
            if (employee == null)
            {
                return NotFound($"Employee with Id : {employeeId} not found");
            }
            return Ok(employee);
        }

        /// <summary>
        /// Sorting employes based on Department
        /// </summary>
        /// <returns></returns>
        [HttpGet("sortByDepartment")]
        public IActionResult GetEmployeeSortByDepertment()
        {
            var sortedEmplyee = _employeeService.GetEmployeesOrderByDepartment();
            return Ok(sortedEmplyee);
        }

        /// <summary>
        /// Sorting Employees by salary(Descending order)
        /// </summary>
        /// <returns></returns>
        [HttpGet("sortBySalary")]
        public IActionResult GetEmployeesSortBySalary()
        {
            var sortedEmployee = _employeeService.GetEmployeeOrderBySalary();
            return Ok(sortedEmployee);
        }
    }
}

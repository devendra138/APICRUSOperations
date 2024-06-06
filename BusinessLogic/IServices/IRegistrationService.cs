
using APICRUDOperations.Models;
using DataAccess.Models;

namespace BusinessLogic.IServices
{
    public interface IRegistrationService
    {
        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns>bool</returns>
        public Task<int?> Add(Employee employee);
    }
}

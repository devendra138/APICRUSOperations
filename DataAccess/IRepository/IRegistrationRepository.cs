using DataAccess.Models;

namespace DataAccess.IRepository
{
    public interface IRegistrationRepository
    {
        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns>bool</returns>
        public Task<int?> Add(Employee employeeModel);
    }
}

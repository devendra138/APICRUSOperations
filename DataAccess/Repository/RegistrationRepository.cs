using DataAccess.IRepository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RegistrationRepository : IRegistrationRepository
    {
        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns>bool</returns>
        public async Task<int?> Add(Employee employee)
        {
            CompanyDetailsContext context = new CompanyDetailsContext();
            var data = await context.AddAsync(employee);
            context.SaveChanges();
            return data.Entity.EmployeeId;
        }
    }
}

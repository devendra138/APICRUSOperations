using APICRUDOperations.Models;
using AutoMapper;
using BusinessLogic.IServices;
using DataAccess.IRepository;
using DataAccess.Models;

namespace BusinessLogic.Services
{
    public class RegistrationService : IRegistrationService
    {
        public readonly IRegistrationRepository _iRegistrationRepository;
        private readonly IMapper _mapper;
        public RegistrationService(IRegistrationRepository registrationRepository, IMapper mapper) 
        {
            _iRegistrationRepository = registrationRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employeeModel"></param>
        /// <returns>bool</returns>
        public async Task<int?> Add(Employee employeeModel)
        {
            //var data = _mapper.Map<Employee>(employeeModel);
            var id = await _iRegistrationRepository.Add(employeeModel);
            return id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using HandsOn.Business;
using HandsOn.Model.DTOs;
using HandsOn.Model.EmployeeFactory;
using HandsOn.Model.Infraestructure;

namespace HandsOn.Controllers
{
    public class EmployeeAPIController : ApiController
    {
        private readonly IBusinessService _businessService;

        public EmployeeAPIController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        [HttpGet]
        public IEnumerable<dynamic> GetAllEmployees(string employeeId)
        {
            IEnumerable<Employee> result = _businessService.GetEmployeesFromAPI();
            AbstractEmployeeFactory factory = new ConcreteEmployeeFactory();

            var empId = -1;
            int.TryParse(employeeId, out empId);

            result = empId > 0 ? result.Where(x => x.Id == empId) : result;

            IEnumerable<dynamic> response = result.Select(o => new
            {
                o.Id,
                o.Name,
                o.ContractTypeName,
                Role = o.RoleName,
                o.HourlySalary,
                o.MonthlySalary,
                Salary = factory.GetSalary(o.ContractTypeName, o)
            });

            return response;
        }
    }
}

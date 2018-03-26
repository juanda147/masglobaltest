using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Model.Infraestructure;
using HandsOn.Model.DTOs;

namespace HandsOn.Model.EmployeeFactory
{
    public abstract class AbstractEmployeeFactory
    {
        public abstract IEmployeeFactory GetTypeEmployee(string type);
    }

    public class ConcreteEmployeeFactory : AbstractEmployeeFactory
    {
        public override IEmployeeFactory GetTypeEmployee(string type)
        {
            switch (type)
            {
                case EmployeeType.Montly:
                    return new HourlySalaryEmployee();

                case EmployeeType.Hourly:
                    return new HourlySalaryEmployee();

                default:
                    throw new ApplicationException(string.Format("Employee type {0} cannot be created", type));
            }
        }
    }
}

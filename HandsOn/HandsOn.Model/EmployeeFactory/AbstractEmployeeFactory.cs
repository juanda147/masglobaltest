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
        public abstract double GetSalary(string type, Employee entity);
    }

    public class ConcreteEmployeeFactory : AbstractEmployeeFactory
    {
        public override double GetSalary(string type, Employee entity)
        {
            switch (type)
            {
                case EmployeeType.Montly:
                    return MonthlySalaryEmployee.GetSalary(entity.MonthlySalary);

                case EmployeeType.Hourly:
                    return HourlySalaryEmployee.GetSalary(entity.HourlySalary);

                default:
                    throw new ApplicationException(string.Format("Employee type {0} cannot be created", type));
            }
        }
    }
}

using HandsOn.Model.EmployeeFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Model.DTOs
{
    public class HourlySalaryEmployee : Employee, IEmployeeFactory
    {
        public double GetSalary()
        {
            return 120 * this.HourlySalary * 12;
        }
    }
}

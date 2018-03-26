using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Model.EmployeeFactory;

namespace HandsOn.Model.DTOs
{
    public class MonthlySalaryEmployee : Employee, IEmployeeFactory
    {
        public double GetSalary()
        {
            return this.MonthlySalary * 12;
        }
    }
}

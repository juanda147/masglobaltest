using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Model.EmployeeFactory;

namespace HandsOn.Model.DTOs
{
    public static class MonthlySalaryEmployee
    {
        public static double GetSalary(double amount)
        {
            return amount * 12;
        }
    }
}

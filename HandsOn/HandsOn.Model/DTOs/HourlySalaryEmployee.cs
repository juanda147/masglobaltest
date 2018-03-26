using HandsOn.Model.EmployeeFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Model.DTOs
{
    public static class HourlySalaryEmployee
    {
        public static double GetSalary(double amount)
        {
            return 120 * amount * 12;
        }
    }
}

using HandsOn.DataAccess.MasGlobalAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Business
{
    public class BusinessService: IBusinessService
    {
        private readonly IMasGlobalAPI _masGlobalApi;

        public BusinessService(IMasGlobalAPI masGlobalApi )
        {
            _masGlobalApi = masGlobalApi;
        }

        public dynamic GetEmployeesFromAPI()
        {
            return _masGlobalApi.GetEmployees();
        }
    }
}

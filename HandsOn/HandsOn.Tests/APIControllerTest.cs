using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandsOn.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.DataAccess.MasGlobalAPI;


namespace HandsOn.Business.Tests
{
    [TestClass()]
    public class APIControllerTest
    {

        [TestMethod()]
        public void GetEmployeesFromAPITest()
        {
            IMasGlobalAPI _masGlobalApi = new MasGlobalAPI();
            var response = _masGlobalApi.GetEmployees();
            Assert.Fail(response != null, "API Response is not null");
        }
    }
}
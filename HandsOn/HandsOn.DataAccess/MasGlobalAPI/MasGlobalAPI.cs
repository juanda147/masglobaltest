using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using HandsOn.Model.DTOs;

namespace HandsOn.DataAccess.MasGlobalAPI
{
    public class MasGlobalAPI: IMasGlobalAPI
    {
        public dynamic GetEmployees()
        {
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetStringAsync(new Uri("http://masglobaltestapi.azurewebsites.net/api/Employees")).Result;

                var jsonEmployees = JArray.Parse(response);

                var employees = JsonConvert.DeserializeObject<List<Employee>>(response);

                return employees;
            }
        }
    }
}

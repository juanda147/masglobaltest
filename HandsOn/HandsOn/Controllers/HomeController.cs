using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOn.Business;

namespace HandsOn.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBusinessService _businessService;

        public HomeController(IBusinessService businessService)
        {
            _businessService = businessService;
        }
         
        public ActionResult Index()
        {
            var employees = _businessService.GetEmployeesFromAPI();

            return View();
        }
    }
}
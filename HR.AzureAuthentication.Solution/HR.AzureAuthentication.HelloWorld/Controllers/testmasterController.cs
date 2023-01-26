using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HR.AzureAuthentication.HelloWorld.Controllers
{
    public class testmasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
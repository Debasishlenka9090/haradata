using HR.AzureAuthentication.HelloWorld.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace HR.AzureAuthentication.HelloWorld.Controllers
{
    //[Authorize]
    
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
           //// Get the group list from the Azure AD.
          //// var groups = User.Claims.Where(c => c.Type == "groups").ToList();
          return View();
        }
       // [Authorize(Policy = "Users")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
       // [Authorize(Policy = "Admins")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
//testmaster1       added 
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

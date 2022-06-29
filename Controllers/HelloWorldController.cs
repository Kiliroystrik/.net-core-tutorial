using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


/* 
    On vient définir le nom du controller qui correspond à une route avec [Controller]
    Ensuite on passe une action à notre controller avec [ActionName]
    Et enfin on peut lui passer un paramètre avec [Parameterss]
    /[Controller]/[ActionName]/[Parameters]
*/
/*
    NB: Razor est un moteur de template
*/

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
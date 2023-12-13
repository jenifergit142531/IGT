using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{

[Route("Prop")]
    public class PropertyController : Controller
    {
        // GET: PropertyController
      public IActionResult Index()
    {
        return View();
    }

        [Route("Fera")]
        public string Welcome()
        {
            return "Welcome to Fera Homes";
        }
        
        [Route("webpage")]
        public RedirectResult Website()
        {
        return Redirect("https://www.feraluxe.com");
        }

         [NonAction]
        public string PropCheck()
        {
            return "Property sold out";
        }

        public string Contact()
        {
            var check=PropCheck();
            return check.ToString();
        }

        public RedirectToActionResult ShowSite()
        {
            return RedirectToAction("Website","Property");
        }

        public RedirectToRouteResult Path()
        {
            return RedirectToRoute(new {Action="Index",Controller="Home"});
        }

    }
}

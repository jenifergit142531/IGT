using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{

//[Route("Prop")]
    public class PropertyController : Controller
    {
        // GET: PropertyController
    


    

    [HttpGet]
    public IActionResult Validation()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Validation(Property p)
    {
        if(ModelState.IsValid)
        {
            return Content("You have successfully posted your property");
        }
        else
        {
            return Content ("Something went wrong...Try again!!!");
        }
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

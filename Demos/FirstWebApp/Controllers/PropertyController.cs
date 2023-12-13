using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{

//[Route("Prop")]
    public class PropertyController : Controller
    {
        // GET: PropertyController

        public IActionResult Index()
        {
            Property[] propshop=new Property[]
            {
                new Property
                {
                   PropertyId=100,
                   PropName="Miramax",
                   Address="Chennai",
                   Age=7,
                   Price=34567,
                   ConsultantName="Jeni",
                   ContactMail="jeni@gmail.com"

                },
                new Property
                {
                   PropertyId=101,
                   PropName="Mira",
                   Address="Pune",
                   Age=5,
                   Price=45678,
                   ConsultantName="Mira",
                   ContactMail="Mira@gmail.com"

                },
                new Property
                {
                   PropertyId=100,
                   PropName="max",
                   Address="Kochi",
                   Age=9,
                   Price=56789,
                   ConsultantName="Max",
                   ContactMail="Max@gmail.com"

                },
            };
            return View(propshop);
        }
    




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

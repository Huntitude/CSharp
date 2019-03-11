using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{

    public class HomeController : Controller
    {

        [HttpGet("")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public ActionResult Result(string name, string location, string language, string textarea)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.textarea = textarea;

            return View();
        }

        //Redirect back to Index if trying to access result page through GET
        [HttpGet("result")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}

       

        // [HttpGet("projects")]
        // public ViewResult Projects()
        // {
        //     return View("Projects");
        // }

        // [HttpGet("contact")]
        // public ViewResult Contact()
        // {
        //     return View("Contact");
        // }





        // // localHost: 5000/
        // [Route("")]
        // [HttpGet]   //request
        // public ViewResult HiThere()
        // {
        //     // Views/Home/HiThere.cshtml
        //     return View();
        // }

        // [HttpGet("runme")]
        // public JsonResult Example()
        // {
        //     var AnonObject = new {
    	//     FirstName = "Raz",
	    //     LastName = "Aquato",
    	//     Age = 10};

        //     return Json(AnonObject);
        // }

        // [HttpGet]
        // [Route("home")]
        // public IActionResult Home()
        // {
        //     // Here we assign the value "Hello World!" to the property .Example
        //     // Property names are arbitrary and can be whatever you like
        //     ViewBag.Example = "Hello World!";
        //     return View();
        // }

        // [HttpGet("hello/{name}")]
        // public ViewResult Hello(string name)
        // {
        //     System.Console.WriteLine($"\n\n\nHello {name}!");
        //     return View();
        // }

        // //This /redirect url will redirect back to /hello path
        // [HttpGet("redirect")]
        // public RedirectToActionResult Redirect()
        // {
        //     System.Console.WriteLine("\n\n\n\nRedirecting to /hello...");
        //     return RedirectToAction("Hello", new{name="paul"});
        // }



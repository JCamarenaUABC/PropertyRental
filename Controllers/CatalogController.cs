using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View(); //Catalog page
        }
        public IActionResult Register()
        {
            return View(); //Register page 
        }

        [HttpPost]
        public IActionResult SaveProperty([FromBody] Property ObjProperty)
        {
            //store PropertyObj into DB
            System.Console.WriteLine("Saving a property");
            System.Console.WriteLine(ObjProperty.Title);

            ObjProperty.Id=1;
            return Json(ObjProperty);            
        }

        
    }
}



using System.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PropertyRental.Models;

namespace PropertyRental.Controllers
{
    public class CatalogController : Controller
    {
        private DataContext dbContext;
        //Constructor
        public CatalogController(DataContext db){            
            dbContext=db;
        }



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
            //System.Console.WriteLine("Saving a property");
            //System.Console.WriteLine(ObjProperty.Title);
            dbContext.Properties.Add(ObjProperty);
            dbContext.SaveChanges();


            ObjProperty.Id=1;
            return Json(ObjProperty);            
        }

        [HttpGet]
        public IActionResult GetProperties()
        {
            var data = dbContext.Properties.ToList(); //all records from table
            return Json(data); //return list/array            
        }
        
        [HttpDelete("/{id:int}")]
        public IActionResult DeleteProperty(int id)
        {
            var theProperty = dbContext.Properties.Find(id);
            dbContext.Properties.Remove(theProperty);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}



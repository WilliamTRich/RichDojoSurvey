using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace IndexController.Controllers;
public class IndexController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("view")] // We will go over this in more detail on the next page
    public ViewResult ViewRes(string name, string dojo, string flang, string comment)
    {
        ViewBag.Name = name;
        ViewBag.Dojo = dojo;
        ViewBag.Flang = flang;
        ViewBag.Comment = comment;
        return View("View");
    }

    [HttpPost("process")]
    public IActionResult Process(Survey survey)
    {
        return RedirectToAction("ViewRes", new { name = survey.Name, dojo = survey.Dojo, flang = survey.Flang, comment = survey.Comment });
    }
}
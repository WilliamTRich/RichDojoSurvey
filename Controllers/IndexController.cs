using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace IndexController.Controllers;
using RichDojoSurvey.Models;
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
    public IActionResult ViewRes(Survey survey)
    {
        ViewBag.Name = survey.Name;
        ViewBag.Dojo = survey.Dojo;
        ViewBag.Flang = survey.Flang;
        ViewBag.Comment = survey.Comment;
        return View("View");
    }

    [HttpPost("process")]
    public IActionResult Process(Survey survey)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("ViewRes", survey);
        }
        else
        {
            return View("Index");
        }
    }
}
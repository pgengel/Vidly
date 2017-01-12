using System;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random() // Subtypes are: ViewResult -> View(),  PartialViewResult -> PartialView(), ContentResult -> Content() ie SimpleText, JsonResult -> Json(), FileResult -> Return a File, HttpNotFoundResult -> 
        {
            var movie = new Movie() { Name = "Shrek" };

            //Below are the outputs of the action results
            //return View(movie)
            //return Content("Simple text")
            //return HttpNotFound()
            //return RedirectToAction("View", "Controller", new {page = 1, sortBy= "name"}) Controller/View?page=1&sortBy=name

            return View(movie);
        }

        public ActionResult Edit(int movieId) //movies/edit/1 or movies/edit?1 because int RoutingCongif.cs movieId is the default BUT movies/edit?movieId=1
        {
            return Content("movieId=" + movieId);
        }

        public ActionResult Index(int? pageIndex, string sortBy) //The pageIndex is optional 
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}
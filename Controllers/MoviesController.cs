using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MovieStoreNew.Models;
using MovieStoreNew.ViewModels;

namespace MovieStoreNew.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie> { new Movie { Id = 1, Name = "Race" }, new Movie { Id = 2, Name = "Race2" } };
        public ActionResult Index()
        {
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = movies.Find(m => m.Id == id);
            if (movie != null)
                return View(movie);
            else
                return HttpNotFound();
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Race"};
            var customers = new List<Customer>{new Customer{Id = 1, Name = "Varun"}, new Customer{Id=2, Name = "Mansi"}};
            var model = new RandomMovieViewModel{Movie = movie, Customers = customers};
            //ViewData["movie"] = movie;
            //ViewBag.Movie = movie;
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
           var movie = new Movie() {Name ="Shrek!"};
        
            return View(movie);
        }

        public ActionResult MoviesList()
        {
            List<Movie> movies = new List<Movie> {
                new Movie() {Name = "Cindrella!", Id = 101 },
                new Movie() {Name = "Aladdin Lamp!" , Id = 102}
            };


            return  View(movies);
        }

        public ActionResult CustomersList()
        {
            //List<Customer> customers = new List<Customer> {
            //    new Customer() {Name = "Johny!", Id = 1},
            //    new Customer() {Name = "Linda!" , Id = 2},
            //     new Customer() {Name = "Maria!" , Id = 3},
            //};
            List<Customer> customers = new List<Customer>();

            return View(customers);
        }
       // [Route("Movies/CustomerDetails/{Id}")]
        public ActionResult CustomerDetails(int id)
        {
            List<Customer> customers = new List<Customer> {
                new Customer() {Name = "Johny Yellow!", Id = 1},
                new Customer() {Name = "Linda M!" , Id = 2},
                 new Customer() {Name = "Bunny!" , Id = 3},
            };
            var customer = customers.Find(m => m.Id == id).Name.ToString();
            return Content(customer);
        }
        //public ActionResult Edit(int movieId)
        //{
        //    return Content("Id:" + movieId);
        //}

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return View();
        //}
    }
}
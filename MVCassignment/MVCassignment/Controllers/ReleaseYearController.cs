using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCassignment.Models;

namespace MVCassignment.Controllers
{
    public class ReleaseYearController : Controller
    {
        // GET: ReleaseYear
        Moviesdbss db = new Moviesdbss();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getReleaseYear()
        {
            List<Movie> molist = (from k in db.Movies where k.dateofRelease = "12/12/2010" select k).ToList();
                return View(molist);

        }
    }

    internal class Moviesdbss
    {
        public object Movies { get; internal set; }
    }
}
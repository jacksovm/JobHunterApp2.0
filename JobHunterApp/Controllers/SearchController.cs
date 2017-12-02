using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobHunterApp.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search(string SearchString)
        {
            ViewBag.SearchString = SearchString;

            ViewBag.Message = "Search";

            return View("SearchResult");
        }
    }
}
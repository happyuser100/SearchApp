using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchInGit.Controllers
{
    public class BookmarkController : Controller
    {
        //
        // GET: /Bookmark/
        public ActionResult Index()
        {
            List<string> reps = new List<string>();
            if (System.Web.HttpContext.Current.Session["Rep"] != null)
               reps = System.Web.HttpContext.Current.Session["Rep"] as List<string>;

            ViewData["Reps"] = reps;

            return View();
        }

    }
}

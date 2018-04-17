using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchInGit.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        public ActionResult Index()
        {
            Session["Rep"] = null;
            return View();
        }
        
        [HttpPost]
        public ActionResult AddBookmark(string rep)
        {
            //add avatar to session
            SessionList.Add(rep);
            return Json("1");
        }

        // List in session
        public List<string> SessionList
        {
            get
            {
                var obj = this.Session["Rep"];
                if (obj == null) { obj = this.Session["Rep"] = new List<string>(); }
                return (List<string>)obj;
            }

            set
            {
                this.Session["Rep"] = value;
            }
        }
    }
}

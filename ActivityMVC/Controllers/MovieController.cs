using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActivityMVC.Controllers
{

    public class MovieController : Controller
    {
            
            // GET: Movie
            public ActionResult Index()
            {
                Models.Movie obj=new Models.Movie();
               
                var lstr = obj.GetDetail();
                return View(lstr);
            }

        }
    }


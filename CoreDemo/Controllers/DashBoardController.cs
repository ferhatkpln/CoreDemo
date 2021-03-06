using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashBoardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == 2).Count();
            ViewBag.v3 = c.Categories.Count().ToString();
            ViewBag.v4 = c.Writers.Count().ToString();
            return View();
        }
    }
}

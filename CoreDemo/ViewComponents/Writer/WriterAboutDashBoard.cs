using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutDashBoard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterById(2);
            return View(values);
        }
    }
}

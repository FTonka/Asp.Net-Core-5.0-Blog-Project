﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c= new Context();
            ViewBag.v1=c.Blogs.Count().ToString();
            ViewBag.v2=c.Blogs.Where(x=>x.BlogID==1).Count().ToString();
            ViewBag.v3=c.Categories.Count().ToString();
            return View();
        }
    }
}

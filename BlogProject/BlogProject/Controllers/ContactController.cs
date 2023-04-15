using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogProject.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cmg = new ContactManager(new EfContactRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Contact c)
		{
			c.ContactStatus = true;
			c.ContactDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			cmg.Add(c);
			return RedirectToAction("Index", "Blog");
		}

	}
}

using BusinessLayer.Concrete;
using BusinessLayer.Fluent_Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogProject.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{

		WriterManager wmg=new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv=new WriterValidator();
			var validateResult=wv.Validate(p);
			if (validateResult.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Kayıt Denemesi";
				p.WriterPassword = BCrypt.Net.BCrypt.HashPassword(p.WriterPassword);
				wmg.Add(p);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach(var item in validateResult.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			
			return View();
		}
		
	}
}

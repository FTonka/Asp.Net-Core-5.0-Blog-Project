using BlogProject.Models;
using BusinessLayer.Concrete;
using BusinessLayer.Fluent_Validation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BlogProject.Controllers
{

	public class WriterController : Controller
	{
		WriterManager wmg = new WriterManager(new EfWriterRepository());
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Test()
        {
            return View();
        }
		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
		[HttpGet]
		[AllowAnonymous]
		public IActionResult WriterEditProfile()
		{
            Context context = new Context();
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values=wmg.GetById(writerID);
			TempData["eskipar"] = values.WriterPassword;
			return View(values);
			
		}
		[HttpPost]
        [AllowAnonymous]

        public IActionResult WriterEditProfile(Writer p)
        {
            var pas1 = Request.Form["pass1"];
            var pas2 = Request.Form["pass2"];
			var eskiParola = Request.Form["eskiParola"];
			if (eskiParola == TempData["eskipar"]) { 
			if (pas1 == pas2)
			{
				p.WriterPassword = pas2;
				WriterValidator wv = new WriterValidator();
				ValidationResult result = wv.Validate(p);
				if (result.IsValid)
				{
					wmg.Update(p);
					return RedirectToAction("Index", "Dashboard");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

					}

				}
			}
            else
            {
                ViewBag.hata = "Girdiğiniz Parolalar Uyuşmuyor!";
            }
			}
			else
			{
				ViewBag.hata1 = "Eski Parolada Hata Var";
			}

            return View();
        }
		public IActionResult WriterImageLocation(AddImageFile p)
        {
            if(p.WriterImage!=null)
			{
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/",
                    newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
				TempData["imagePath"] = newImageName;
            }
			return View();
		}


    }
}

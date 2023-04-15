using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;

namespace BlogProject.Controllers
{
	public class CommentController : Controller
	{

		CommentManager cmg = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult CommentListByBlog()
		{
			return PartialView();
		}
		[HttpGet]
		public PartialViewResult AddCommentToBlog()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult AddCommentToBlog(Comment c)
		{
			c.CommmentStatus = true;
			c.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			c.BlogID = 2;
			cmg.Add(c);

			return RedirectToAction("Index","Blog");
		}
	}
}

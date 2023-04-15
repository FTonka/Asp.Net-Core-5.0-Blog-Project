using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.GetLast3Blog
{
	public class GetLast3Blog:ViewComponent
	{
		BlogManager bmg = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var values = bmg.GetLast3Blog();
			return View(values);
		}
	}
}

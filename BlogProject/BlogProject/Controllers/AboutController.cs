using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
	public class AboutController : Controller
	{
		AboutManager amg=new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values=amg.GetListAll();
			return View(values);
		}
		public PartialViewResult SocialMedia()
		{
			return PartialView();
		}
		
	}
}

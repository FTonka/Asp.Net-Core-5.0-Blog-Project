using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Blog
{
	public class GetWritersBlog:ViewComponent
	{
		BlogManager bmg2 = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke()
		{
			var usermail = User.Identity.Name;
			Context c=new Context();
			var writerID=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterID).FirstOrDefault();
			var values=bmg2.GetBlogByWriter(writerID);
			return View(values);
		}
	}
}

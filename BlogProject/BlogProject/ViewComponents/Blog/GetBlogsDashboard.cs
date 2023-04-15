using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Blog
{
    public class GetBlogsDashboard:ViewComponent
    {
        BlogManager bmg=new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bmg.GetListWithCategory();
            return View(values);
        }
    }
}

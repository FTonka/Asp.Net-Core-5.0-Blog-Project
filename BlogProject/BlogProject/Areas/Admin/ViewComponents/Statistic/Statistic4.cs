using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        AdminManager amg=new AdminManager(new EfAdminRepository());
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=c.Admins.Where(x=>x.AdminID==1).Select(y=>y.AdminName).FirstOrDefault();
            ViewBag.v2=c.Admins.Where(x=>x.AdminID==1).Select(y=>y.AdminImageUrl).FirstOrDefault();
            ViewBag.v3=c.Admins.Where(x=>x.AdminID==1).Select(y=>y.AdminShortDescription).FirstOrDefault();
            return View();
        }
    }
}

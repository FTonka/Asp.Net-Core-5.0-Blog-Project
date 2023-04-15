using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager nmg=new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nmg.GetAll().Where(x=>x.NotificationStatus==true).ToList();
            return View(values);
        }
    }
}   

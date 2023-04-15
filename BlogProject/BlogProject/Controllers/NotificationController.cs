using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nmg=new NotificationManager(new EfNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllNotification() {
            var values = nmg.GetAll();
            return View(values);
        }
    }
}

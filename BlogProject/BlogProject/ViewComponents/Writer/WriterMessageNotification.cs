using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.ViewComponents.WriterMessageNotification
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mmg=new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            int id = writerID;
            var values = mmg.GetMessageByMail(id);
            ViewBag.totalMessages=mmg.GetListAll().Count.ToString();
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mmg = new Message2Manager(new EfMessage2Repository());

        public IActionResult GetAllMessages()
        {
            Context context = new Context();
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mmg.GetMessageByMail(writerID);
            return View(values);
           
        }
        public IActionResult MessageDetails(int id)
        {
            var values = mmg.GetById(id);
            return View(values);

        }
    }
}

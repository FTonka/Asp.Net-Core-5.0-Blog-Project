using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetBlogListWithMessageByWriter(int id)
        {
            Context c = new Context();
            return c.Messages2.Include(x=>x.SenderUser).Where(x=>x.MessageReceiverID==id).ToList();
        }
    }
}

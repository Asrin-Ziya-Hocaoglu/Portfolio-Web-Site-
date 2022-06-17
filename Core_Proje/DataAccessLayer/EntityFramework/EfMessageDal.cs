using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal:GenericRepository<Message>,IMessageDal
    {
        public List<Message> GetLastFive()
        {
            using var c = new Context();
            var countOfMessages = c.Messages.Count();
            return c.Set<Message>().Where(x => x.MessageId > countOfMessages - 3).ToList();
        }
    }
}

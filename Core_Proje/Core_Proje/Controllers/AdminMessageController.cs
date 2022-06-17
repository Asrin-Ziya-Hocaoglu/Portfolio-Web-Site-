using System;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult IncomingMessage()
        {
            TempData["DeleteUrl"] = "IncomingMessage";
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult OutGoingMessage()
        {
            TempData["DeleteUrl"] = "OutGoingMessage";
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        public IActionResult AdminMessageDetails(int id)
        {

            var values = writerMessageManager.TGetById(id);
            return View(values);
        }

        public IActionResult AdminMessageDelete(int id)
        {
            string viewUrl = TempData["DeleteUrl"].ToString();
            var values = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction(viewUrl);
        }

        [HttpGet]

        public IActionResult AddAdminMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdminMessage(WriterMessage writerMessage)
        {
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date =DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();

            var userNameSurname = c.Users.Where(x => x.Email == writerMessage.Receiver)
                .Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("OutGoingMessage");
        }
    }
}

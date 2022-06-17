﻿using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        private WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WriterMessageId).Take(3).ToList();
            return View(values);
        }
    }
}

//using System.Linq;

using System;
using System.Linq;
using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message p)
        {

            MessageManager messageManager = new MessageManager(new EfMessageDal());
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            messageManager.TAdd(p);
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        //[HttpGet]
        //public PartialViewResult SendMessage()
        //{
        //    return PartialView();
        //}
        //[HttpPost]
        //public IActionResult SendMessage(Message p)
        //{
        //    MessageManager messageManager = new MessageManager(new EfMessageDal());
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManager.TAdd(p);

        //    return RedirectToAction("Index", "Default");
        //}

        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
    }
}

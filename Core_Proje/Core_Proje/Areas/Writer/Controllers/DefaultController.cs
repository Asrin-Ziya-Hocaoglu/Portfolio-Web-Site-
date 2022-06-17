﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
   
    [Authorize]
    public class DefaultController : Controller
    {
        private AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }
     
        public IActionResult AnnouncementDetails(int id)
        {

            Announcement announcement = announcementManager.TGetById(id);
            return View(announcement);
        }
    }
}

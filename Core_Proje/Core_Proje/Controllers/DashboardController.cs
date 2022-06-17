using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private Context c = new Context();
        public IActionResult Index()
        {
            
            ViewBag.SkillCount = c.Skills.Count();
            ViewBag.MessagesCountTrue = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.MessagesCountFalse = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.ExperiencesCount = c.Experience.Count();
            return View();
        }

       
       

    }
}

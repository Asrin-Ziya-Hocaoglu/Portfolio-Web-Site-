using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }
        public  PartialViewResult _NavbarPartial()
        {
            
            return PartialView();
        }
        public PartialViewResult _ScriptsPartial()
        {
            return PartialView();
        }

        public PartialViewResult NewSideBar()
        {
            return PartialView();
        }

    }
}

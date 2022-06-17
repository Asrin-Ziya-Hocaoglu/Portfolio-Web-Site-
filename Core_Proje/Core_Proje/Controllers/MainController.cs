using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MainController : Controller
    {
        private HomeManager homeManager = new HomeManager(new EfHomeDal());
        [HttpGet]
        public IActionResult Index()
        {
            
            var values = homeManager.TGetById(1);
            return View(values);
        }

    
       

        [HttpPost]
        public IActionResult Index(Home home )
        {
            homeManager.TUpdate(home);
            return RedirectToAction("Index","Default");

        }
    }
}

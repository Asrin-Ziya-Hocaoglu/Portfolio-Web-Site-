using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ResumeController : Controller
    {
        private ResumeManager resumeManager = new ResumeManager(new EfResumeDal());
        public IActionResult Index()
        {
       
            var values = resumeManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddResume()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult AddResume(Resume resume)
        {
            resumeManager.TAdd(resume);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteResume(int id)
        {
            var values = resumeManager.TGetById(id);
            resumeManager.TDelete(values);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditResume(int id)
        {
           
            var values = resumeManager.TGetById(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult EditResume(Resume resume)
        {
            resumeManager.TUpdate(resume);
            return RedirectToAction("Index");
        }
    }
}

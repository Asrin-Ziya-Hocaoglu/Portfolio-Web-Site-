using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class Experience_2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
       
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());

            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            var values = JsonConvert.SerializeObject(experience);

            return Json(values);


        }

        public IActionResult GetById(int ExperienceId)
        {

            var getExperience = experienceManager.TGetById(ExperienceId);
            var values = JsonConvert.SerializeObject(getExperience);
            return Json(values);
        }
      
        public IActionResult DeleteExperience(int id)
        {
            var getExperience = experienceManager.TGetById(id);
            experienceManager.TDelete(getExperience);
            return NoContent();

        }
    }
}

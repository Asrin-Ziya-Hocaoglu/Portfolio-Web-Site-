using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Resume
{
    public class ResumeList:ViewComponent
    {
        private ResumeManager resumeManager = new ResumeManager(new EfResumeDal());
        private EducationManager educationManager = new EducationManager(new EfEducationDal());
        private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = resumeManager.TGetList();
            return View(values);
        }
    }
}

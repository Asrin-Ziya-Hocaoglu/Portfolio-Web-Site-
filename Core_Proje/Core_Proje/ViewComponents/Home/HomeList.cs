using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Home
{
    public class HomeList:ViewComponent
    {
        private HomeManager homeManager = new HomeManager(new EfHomeDal());
        public IViewComponentResult Invoke()
        {
            var values = homeManager.TGetList();
            return View(values);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    public class WriterUserController : Controller
    {
        private WriterManager _writerManager = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult ListUser()
        {
            var values = JsonConvert.SerializeObject(_writerManager.TGetList());

            return Json(values);
        }

        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            _writerManager.TAdd(writerUser);
            var values = JsonConvert.SerializeObject(writerUser);

            return Json(values);


        }
    }
}

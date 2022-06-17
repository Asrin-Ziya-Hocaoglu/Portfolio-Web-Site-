using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class DashboardWriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserName = values.Name +" "+ values.Surname;


            // Weather Api
            string api = "14ad2aba611dbef9c504b82a127794c5";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.WeatherApi = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;


            Context c = new Context();
            ViewBag.Messages = c.WriterMessages.Where(x=>x.Receiver==values.Email).Count();
            ViewBag.Announcements = c.Announcements.Count();
            ViewBag.UsersNumber = c.Users.Count();
            ViewBag.SkillNumber = c.WriterMessages.Where(x=>x.Sender==values.Email).Count();
            return View();
        }
    }
}

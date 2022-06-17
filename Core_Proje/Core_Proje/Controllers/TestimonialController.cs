using System;
using System.IO;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public TestimonialController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(AddTestimonialModel addTestimonialModel)
        {


            if (addTestimonialModel.Picture!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(addTestimonialModel.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/Image/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                addTestimonialModel.Picture.CopyTo(stream);
                addTestimonialModel.ImageUrl = "/Image/" + imagename;
            }
              
            
            Testimonial testimonial = new Testimonial()
            {
                ClientName = addTestimonialModel.ClientName,
                Comment = addTestimonialModel.Comment,
                Profession = addTestimonialModel.Profession,
                ImageUrl = addTestimonialModel.ImageUrl

            };




            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = testimonialManager.TGetById(id);
            testimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = testimonialManager.TGetById(id);
            UpdateTestimonialModel updateTestimonialModel = new UpdateTestimonialModel();
            updateTestimonialModel.ClientName = values.ClientName;
            updateTestimonialModel.Comment = values.Comment;
            updateTestimonialModel.Profession = values.Profession;
            updateTestimonialModel.ImageUrl = values.ImageUrl;
            updateTestimonialModel.Id = id;


            return View(updateTestimonialModel);
        }


        [HttpPost]
        public IActionResult UpdateTestimonial(UpdateTestimonialModel updateTestimonialModel, int id)
        {
            var values = testimonialManager.TGetById(id);
            if (updateTestimonialModel.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(updateTestimonialModel.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/Image/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                updateTestimonialModel.Picture.CopyTo(stream);
                values.ImageUrl = "/Image/" + imagename;
            }

            values.TestimonialId = id;
            values.ClientName = updateTestimonialModel.ClientName;
            values.Comment = updateTestimonialModel.Comment;
            values.Profession = updateTestimonialModel.Profession;

            testimonialManager.TUpdate(values);


            return RedirectToAction("Index", "Testimonial");
        }


        //[HttpGet]
        //public IActionResult UpdateTestimonial( int id)
        //{
        //    var values =  testimonialManager.TGetById(id);

        //    return View(values);

        //}
        //[HttpPost]
        //public  IActionResult  UpdateTestimonial(Testimonial testimonial)
        //{

        //    testimonialManager.TUpdate(testimonial);
        //    return RedirectToAction("Index");


        //}
    }
}

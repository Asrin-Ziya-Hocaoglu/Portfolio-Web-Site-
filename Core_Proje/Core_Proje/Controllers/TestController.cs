using System;
using System.IO;
using BusinessLayer.Concrete;
using Core_Proje.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class TestController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());

        public TestController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
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
            if (updateTestimonialModel.Picture!=null)
            {
                var wwwRootPath = _hostEnvironment.WebRootPath;
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
    }
}

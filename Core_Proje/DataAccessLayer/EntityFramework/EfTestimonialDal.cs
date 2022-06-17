using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public async Task<Testimonial> UpdateAsync(Testimonial testimonial)
        {
            await using var c = new Context();

            await Task.Run(() =>
            {
                 c.Set<Testimonial>().Update(testimonial);
            
        });
        return testimonial;



        }
    }
}

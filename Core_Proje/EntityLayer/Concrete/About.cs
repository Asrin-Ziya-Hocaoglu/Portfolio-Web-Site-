using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Profession { get; set; }
        public string Introduction { get; set; }
        
        public string Description { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Degree { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }


        
        
        
           
    }
}

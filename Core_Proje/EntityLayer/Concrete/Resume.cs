using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Resume
    {
        [Key]
        public int ResumeId { get; set; }
        public string Name { get; set; }
        public string SummaryDescription { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }

        
    }
}

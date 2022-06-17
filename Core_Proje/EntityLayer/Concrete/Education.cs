using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        public int EducationId { get; set; }
        public string Name  { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string School { get; set; }
    }
}

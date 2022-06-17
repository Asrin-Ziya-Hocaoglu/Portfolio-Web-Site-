using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IPortfolioDal:IGenericDal<Portfolio>
    {
        List<Portfolio> GetLastFive();
    }
}

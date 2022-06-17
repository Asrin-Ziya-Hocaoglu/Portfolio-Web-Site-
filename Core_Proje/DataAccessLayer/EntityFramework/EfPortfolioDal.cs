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
    public class EfPortfolioDal:GenericRepository<Portfolio>,IPortfolioDal
    {
        public List<Portfolio> GetLastFive()
        {
            using var c = new Context();
            var countOfPortfolios =c.Portfolios.Count();
            return c.Set<Portfolio>().Where(x => x.PortfolioId >countOfPortfolios-5).ToList();
        }
    }
}

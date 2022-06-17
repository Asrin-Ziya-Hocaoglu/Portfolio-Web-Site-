using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HomeManager:IHomeService
    {
        private IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void TAdd(Home t)
        {
            _homeDal.Insert(t);
        }

        public void TDelete(Home t)
        {
            _homeDal.Delete(t);
        }

        public void TUpdate(Home t)
        {
            _homeDal.Update(t);
        }

        public List<Home> TGetList()
        {
            return _homeDal.GetList();
        }

        public Home TGetById(int id)
        {
           return  _homeDal.GetById(id);
        }

        public List<Home> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public Task<Home> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class ResumeManager:IResumeService
    {
        private IResumeDal _resumeDal;

        public ResumeManager(IResumeDal resumeDal)
        {
            _resumeDal = resumeDal;
        }

        public void TAdd(Resume t)
        {
            _resumeDal.Insert(t);
        }

        public void TDelete(Resume t)
        {
            _resumeDal.Delete(t);
        }

        public void TUpdate(Resume t)
        {
            _resumeDal.Update(t);
        }

        public List<Resume> TGetList()
        {
            return _resumeDal.GetList();
        }

        public Resume TGetById(int id)
        {
            return _resumeDal.GetById(id);
        }

        public List<Resume> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public Task<Resume> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

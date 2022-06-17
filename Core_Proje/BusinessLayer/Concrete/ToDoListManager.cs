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
    public class ToDoListManager:IToDoListService
    {
        private IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TAdd(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList t)
        {
            _toDoListDal.Delete(t);
            
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDal.GetList();
        }

        public ToDoList TGetById(int id)
        {
            return _toDoListDal.GetById(id);
        }

        public List<ToDoList> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoList> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Concrete.Managers
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll(Expression<Func<User,bool>> filter = null)
        {
            return filter == null ? _userDal.GetList() : _userDal.GetList(filter);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return _userDal.Get(filter);
        }

        public User GetById(int id)
        {
            return _userDal.Get(x=>x.UserID == id);
        }

        public User Add(User entity)
        {
            return _userDal.Add(entity);
        }

        public User Update(User entity)
        {
            return _userDal.Update(entity);
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }
    }
}

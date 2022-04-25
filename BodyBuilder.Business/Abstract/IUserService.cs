using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        User Get(Expression<Func<User, bool>> filter);
        User GetById(int id);
        User Add(User entity);
        User Update(User entity);
        void Delete(User entity);
    }
}

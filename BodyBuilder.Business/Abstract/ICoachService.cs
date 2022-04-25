using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface ICoachService
    {
        List<Coach> GetAll(Expression<Func<Coach, bool>> filter = null);
        Coach Get(Expression<Func<Coach, bool>> filter);
        Coach GetById(int id);
        Coach Add(Coach entity);
        Coach Update(Coach entity);
        void Delete(Coach entity);
    }
}

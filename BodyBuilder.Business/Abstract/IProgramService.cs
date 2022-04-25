using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface IProgramService
    {
        List<Program> GetAll(Expression<Func<Program, bool>> filter = null);
        Program Get(Expression<Func<Program, bool>> filter);
        Program GetById(int id);
        Program Add(Program entity);
        Program Update(Program entity);
        void Delete(Program entity);
    }
}

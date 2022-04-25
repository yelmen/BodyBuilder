using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface ITrainService
    {
        List<Training> GetAll(Expression<Func<Training, bool>> filter = null);
        Training Get(Expression<Func<Training, bool>> filter);
        Training GetById(int id);
        Training Add(Training entity);
        Training Update(Training entity);
        void Delete(Training entity);
    }
}

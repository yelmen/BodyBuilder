using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface IWorkDayService
    {
        List<WorkDay> GetAll(Expression<Func<WorkDay, bool>> filter = null);
        WorkDay Get(Expression<Func<WorkDay, bool>> filter);
        WorkDay GetById(int id);
        WorkDay Add(WorkDay entity);
        WorkDay Update(WorkDay entity);
        void Delete(WorkDay entity);
    }
}

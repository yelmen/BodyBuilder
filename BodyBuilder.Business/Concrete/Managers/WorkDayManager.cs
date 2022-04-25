using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Concrete.Managers
{
    public class WorkDayManager:IWorkDayService
    {
        private IWorkDayDal _workDayDal;

        public WorkDayManager(IWorkDayDal workDayDal)
        {
            _workDayDal = workDayDal;
        }

        public List<WorkDay> GetAll(Expression<Func<WorkDay, bool>> filter = null)
        {
            return filter == null ? _workDayDal.GetList() : _workDayDal.GetList(filter);
        }

        public WorkDay Get(Expression<Func<WorkDay, bool>> filter)
        {
            return _workDayDal.Get(filter);
        }

        public WorkDay GetById(int id)
        {
            return _workDayDal.Get(x => x.DayId == id);
        }

        public WorkDay Add(WorkDay entity)
        {
            return _workDayDal.Add(entity);
        }

        public WorkDay Update(WorkDay entity)
        {
            return _workDayDal.Update(entity);
        }

        public void Delete(WorkDay entity)
        {
            _workDayDal.Delete(entity);
        }
    }
}

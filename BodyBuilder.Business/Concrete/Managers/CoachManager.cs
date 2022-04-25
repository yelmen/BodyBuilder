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
    public class CoachManager:ICoachService
    {
        private ICoachDal _coachDal;

        public CoachManager(ICoachDal coachDal)
        {
            _coachDal = coachDal;
        }

        public List<Coach> GetAll(Expression<Func<Coach, bool>> filter = null)
        {
            return filter == null ? _coachDal.GetList() : _coachDal.GetList(filter);
        }

        public Coach Get(Expression<Func<Coach, bool>> filter)
        {
            return _coachDal.Get(filter);
        }

        public Coach GetById(int id)
        {
            return _coachDal.Get(x=>x.CoachId == id);
        }

        public Coach Add(Coach entity)
        {
            return _coachDal.Add(entity);
        }

        public Coach Update(Coach entity)
        {
            return _coachDal.Update(entity);
        }

        public void Delete(Coach entity)
        {
            _coachDal.Delete(entity);
        }
    }
}

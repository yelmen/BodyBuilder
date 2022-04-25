using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Concrete.Managers
{
    public class TrainManager:ITrainService
    {
        private ITrainDal _trainDal;

        public TrainManager(ITrainDal trainDal)
        {
            _trainDal = trainDal;
        }
        public List<Training> GetAll(Expression<Func<Training, bool>> filter = null)
        {
            return filter == null ? _trainDal.GetList() : _trainDal.GetList(filter);
        }

        public Training Get(Expression<Func<Training, bool>> filter)
        {
            return _trainDal.Get(filter);
        }

        public Training GetById(int id)
        {
            return _trainDal.Get(x => x.TrainingId == id);
        }

        public Training Add(Training entity)
        {
            return _trainDal.Add(entity);
        }

        public Training Update(Training entity)
        {
            return _trainDal.Update(entity);
        }

        public void Delete(Training entity)
        {
            _trainDal.Delete(entity);
        }
    }
}

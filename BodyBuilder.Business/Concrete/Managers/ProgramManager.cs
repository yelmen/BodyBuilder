using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.DependencyResolvers.Ninject;
using BodyBuilder.Core.DataAccess;
using BodyBuilder.Core.Entities;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;
using Ninject;

namespace BodyBuilder.Business.Concrete.Managers
{
    public class ProgramManager:IProgramService
    {
        private IProgramDal _programDal;



        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }


        public List<Program> GetAll(Expression<Func<Program, bool>> filter = null)
        {
            return filter == null ? _programDal.GetList() : _programDal.GetList(filter);
        }

        public Program Get(Expression<Func<Program, bool>> filter)
        {
            return _programDal.Get(filter);
        }

        public Program GetById(int id)
        {
            return _programDal.Get(x => x.ProgramId == id);
        }

        public Program Add(Program entity)
        {
            return _programDal.Add(entity);
        }

        public Program Update(Program entity)
        {
            return _programDal.Update(entity);
        }

        public void Delete(Program entity)
        {
            _programDal.Delete(entity);
        }

        
    }
}

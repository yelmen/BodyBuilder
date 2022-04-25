using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Core.DataAccess;
using BodyBuilder.Core.DataAccess.EntityFramework;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using Ninject.Modules;

namespace BodyBuilder.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<ICoachService>().To<CoachManager>().InSingletonScope();
            Bind<ICoachDal>().To<EfCoachDal>();

            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>();

            Bind<IProgramService>().To<ProgramManager>().InSingletonScope();
            Bind<IProgramDal>().To<EfProgramDal>();

            Bind<ITrainService>().To<TrainManager>().InSingletonScope();
            Bind<ITrainDal>().To<EfTrainingDal>();

            Bind<IWorkDayService>().To<WorkDayManager>().InSingletonScope();
            Bind<IWorkDayDal>().To<EfWorkDayDal>();


            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<BodyBuilderContext>();
        }
    }
}

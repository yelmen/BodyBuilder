using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.DataAccess.EntityFramework;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers
{
    public class EfTrainingDal:EfEntityRepositoryBase<Training,BodyBuilderContext>,ITrainDal
    {
    }
}

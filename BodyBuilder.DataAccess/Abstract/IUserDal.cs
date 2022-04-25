using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.DataAccess;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}

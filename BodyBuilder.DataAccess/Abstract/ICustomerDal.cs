using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.DataAccess;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<WorkProgram> GetPrograms();
        List<WorkProgram> GetProgramsByCustomerId(int CustomerId,string dayName = null);
        List<WorkProgram> GetProgramsByKey(string key);
        List<WorkProgram> GetDaysByCustomerId(int customerId);
    }
}

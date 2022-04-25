using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null);
        Customer Get(Expression<Func<Customer, bool>> filter);
        Customer GetById(int id);
        Customer Add(Customer entity);
        Customer Update(Customer entity);
        void Delete(Customer entity);
    }
}

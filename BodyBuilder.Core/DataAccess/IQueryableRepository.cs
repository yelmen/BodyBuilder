using System.Linq;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class User:IEntity
    {
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
    }
}

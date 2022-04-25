using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class WorkDay:IEntity
    {
        public int DayId { get; set; }
        public string DayName { get; set; }
    }
}

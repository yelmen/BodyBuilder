using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class Program:IEntity
    {
        public int  ProgramId { get; set; }
        public int CustomerId { get; set; }
        public int? TrainingId { get; set; }
        public int DayId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class Training:IEntity
    {
        public int TrainingId { get; set; }
        public string TrainingName { get; set; }
        public string WorkAmount { get; set; }
        
    }
}

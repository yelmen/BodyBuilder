using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class Coach:IEntity
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public string CoachSurname { get; set; }
        public string CoachUsername { get; set; }
        public string CoahPassword { get; set; }

    }
}

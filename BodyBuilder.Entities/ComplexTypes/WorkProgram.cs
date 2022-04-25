using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyBuilder.Entities.ComplexTypes
{
    public class WorkProgram
    {
        public int ProgramId { get; set; }
        public int  CustomerID { get; set; }
        public string TrainName { get; set; }
        public string DayName { get; set; }
        public string WorkAmount { get; set; }
        public int DayId { get; set; }

    }
}

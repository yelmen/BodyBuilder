using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class Customer:IEntity   
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerTc { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public double CustomerWeight { get; set; }
        public double CustomerSize { get; set; }
        public int CustomerAge { get; set; }
        public int CoachId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}

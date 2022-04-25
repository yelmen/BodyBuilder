using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.Entities;

namespace BodyBuilder.Entities.Concrete
{
    public class Member:IEntity
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public DateTime MemberStartDate { get; set; }
        public DateTime MemberFinishDate { get; set; }
        public Int16 MemberAge { get; set; }
        public double MemberSize { get; set; }
        public Int16 MemberWeight { get; set; }
        public string MemberAddress { get; set; }
        public int UserID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MemberMap:EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            ToTable(@"Members", @"dbo");
            HasKey(x => x.MemberID);

            Property(x => x.UserID).HasColumnName("UserID");
            Property(x => x.MemberName).HasColumnName("MemberName");
            Property(x => x.MemberSurname).HasColumnName("MemberSurname");
            Property(x => x.MemberStartDate).HasColumnName("MemberStartDate");
            Property(x => x.MemberFinishDate).HasColumnName("MemberFinishDate");
            Property(x => x.MemberAddress).HasColumnName("MemberAddress");
            Property(x => x.MemberAge).HasColumnName("MemberAge");
            Property(x => x.MemberWeight).HasColumnName("MemberWeight");
            Property(x => x.MemberSize).HasColumnName("MemberSize");
        }
    }
}

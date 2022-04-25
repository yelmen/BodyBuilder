using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.UserID);

            Property(x => x.UserID).HasColumnName("UserID");
            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.Password).HasColumnName("UserPassword");
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.Surname).HasColumnName("Surname");
        }

    }
}

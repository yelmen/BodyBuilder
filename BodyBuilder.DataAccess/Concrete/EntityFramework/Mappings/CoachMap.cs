using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CoachMap:EntityTypeConfiguration<Coach>
    {
        public CoachMap()
        {
            ToTable(@"Coaches", @"dbo");
            HasKey(x => x.CoachId);

            Property(x => x.CoachId).HasColumnName("coachId");
            Property(x => x.CoachName).HasColumnName("coachName");
            Property(x => x.CoachSurname).HasColumnName("coachSurname");
            Property(x => x.CoachUsername).HasColumnName("coachUsername");
            Property(x => x.CoahPassword).HasColumnName("coachPassword");
        }
    }
}

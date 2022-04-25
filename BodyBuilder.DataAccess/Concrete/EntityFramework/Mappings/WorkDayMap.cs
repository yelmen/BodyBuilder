using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class WorkDayMap:EntityTypeConfiguration<WorkDay>
    {
        public WorkDayMap()
        {
            ToTable(@"WorkDays", @"dbo");
            HasKey(x => x.DayId);

            Property(x => x.DayId).HasColumnName("dayId");
            Property(x => x.DayName).HasColumnName("workday");
        }
    }
}

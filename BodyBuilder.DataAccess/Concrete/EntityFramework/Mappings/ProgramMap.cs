using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProgramMap : EntityTypeConfiguration<Program>
    {
        public ProgramMap()
        {
            ToTable(@"Program", @"dbo");
            HasKey(x => x.ProgramId);

            Property(x => x.ProgramId).HasColumnName("ProgramId");
            Property(x => x.CustomerId).HasColumnName("CustomerId");
            Property(x => x.TrainingId).HasColumnName("TrainingId");
            Property(x => x.DayId).HasColumnName("DayId");
        }
    }
}

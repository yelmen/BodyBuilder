using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TrainingMap:EntityTypeConfiguration<Training>
    {
        public TrainingMap()
        {
            ToTable(@"training", @"dbo");
            HasKey(x => x.TrainingId);

            Property(x => x.TrainingId).HasColumnName("trainingtId");
            Property(x => x.TrainingName).HasColumnName("trainingName");
            Property(x => x.WorkAmount).HasColumnName("WorkAmount");
        }
    }
}

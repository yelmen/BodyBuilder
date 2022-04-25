using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable(@"Customer", @"dbo");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("customerId");
            Property(x => x.CustomerName).HasColumnName("customerName");
            Property(x => x.CustomerSurname).HasColumnName("customerSurname");
            Property(x => x.CustomerTc).HasColumnName("customerTc");
            Property(x => x.CustomerAddress).HasColumnName("customerAddress");
            Property(x => x.CustomerPhone).HasColumnName("customerPhone");
            Property(x => x.CustomerWeight).HasColumnName("customerWeight");
            Property(x => x.CustomerSize).HasColumnName("customerSize");
            Property(x => x.CustomerAge).HasColumnName("customerAge");
            Property(x => x.CoachId).HasColumnName("coachId");
            Property(x => x.startDate).HasColumnName("startDate");
            Property(x => x.endDate).HasColumnName("endDate");

        }
    }
}

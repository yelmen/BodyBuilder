using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.DataAccess.Concrete.EntityFramework.Mappings;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework
{
    public class BodyBuilderContext:DbContext
    {
        public BodyBuilderContext()
        {
            Database.SetInitializer<BodyBuilderContext>(null);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Program>  Programs { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new CoachMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ProgramMap());
            modelBuilder.Configurations.Add(new TrainingMap());
            modelBuilder.Configurations.Add(new WorkDayMap());


        }
    }
}

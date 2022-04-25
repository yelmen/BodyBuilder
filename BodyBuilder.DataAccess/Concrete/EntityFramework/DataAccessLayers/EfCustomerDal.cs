using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.DataAccess.EntityFramework;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,BodyBuilderContext>,ICustomerDal
    {
 

        public List<WorkProgram> GetPrograms()
        {
            using (BodyBuilderContext context = new BodyBuilderContext())
            {
                var result = from p in context.Programs
                    join c in context.Customers on p.CustomerId equals c.CustomerId
                    join t in context.Trainings on p.TrainingId equals t.TrainingId
                    join w in context.WorkDays on p.DayId equals w.DayId
                    select new WorkProgram
                    {
                        ProgramId = p.ProgramId,
                        CustomerID = c.CustomerId,
                        DayName = w.DayName,
                        WorkAmount = t.WorkAmount,
                        TrainName = t.TrainingName,
                        DayId = p.DayId
                    };
                return result.ToList();
            }
        }

        public List<WorkProgram> GetProgramsByKey(string key)
        {
            using (BodyBuilderContext context = new BodyBuilderContext())
            {
                var result = from p in context.Programs
                    join c in context.Customers on p.CustomerId equals c.CustomerId
                    join t in context.Trainings on p.TrainingId equals t.TrainingId
                    join w in context.WorkDays on p.DayId equals w.DayId
                             where t.TrainingName.Contains(key) 
                    select new WorkProgram
                    {
                        ProgramId = p.ProgramId,
                        CustomerID = c.CustomerId,
                        DayName = w.DayName,
                        WorkAmount = t.WorkAmount,
                        TrainName = t.TrainingName,
                        DayId = p.DayId
                    };
                return result.ToList();
            }
        }


        public List<WorkProgram> GetProgramsByCustomerId(int CustomerId,string dayName = null)
        {
            if (dayName != null)
            {
                using (BodyBuilderContext context = new BodyBuilderContext())
                {
                    var result = from p in context.Programs
                        join c in context.Customers on p.CustomerId equals c.CustomerId
                        join t in context.Trainings on p.TrainingId equals t.TrainingId
                        join w in context.WorkDays on p.DayId equals w.DayId
                        where p.CustomerId == CustomerId && w.DayName == dayName
                        select new WorkProgram
                        {
                            ProgramId = p.ProgramId,
                            CustomerID = c.CustomerId,
                            DayName = w.DayName,
                            WorkAmount = t.WorkAmount,
                            TrainName = t.TrainingName,
                            DayId = p.DayId
                        };
                    return result.ToList();
                }
            }
            else
            {
                using (BodyBuilderContext context = new BodyBuilderContext())
                {
                    var result = from p in context.Programs
                        join c in context.Customers on p.CustomerId equals c.CustomerId
                        join t in context.Trainings on p.TrainingId equals t.TrainingId
                        join w in context.WorkDays on p.DayId equals w.DayId
                        where p.CustomerId == CustomerId
                        select new WorkProgram
                        {
                            ProgramId = p.ProgramId,
                            CustomerID = c.CustomerId,
                            DayName = w.DayName,
                            WorkAmount = t.WorkAmount,
                            TrainName = t.TrainingName,
                            DayId = p.DayId
                        };
                    return result.ToList();
                }
            }
            
        }

        public List<WorkProgram> GetDaysByCustomerId(int customerId)
        {
            using (BodyBuilderContext context = new BodyBuilderContext())
            {
                var result = from p in context.Programs
                    join c in context.Customers on p.CustomerId equals c.CustomerId
                    join w in context.WorkDays on p.DayId equals w.DayId
                    where p.CustomerId == customerId 
                    select new WorkProgram
                    {
                        ProgramId = p.ProgramId,
                        CustomerID = c.CustomerId,
                        DayName = w.DayName,
                        DayId = p.DayId
                    };
                return result.ToList();
            }
        }


    }
}

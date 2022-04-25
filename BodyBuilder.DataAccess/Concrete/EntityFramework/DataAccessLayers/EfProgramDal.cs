using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodyBuilder.Core.DataAccess.EntityFramework;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;
using Ninject;

namespace BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers
{
    public class EfProgramDal:EfEntityRepositoryBase<Program,BodyBuilderContext>,IProgramDal
    {
        private EfTrainingDal _trainingDal = new EfTrainingDal();
        private EfWorkDayDal _workDayDal = new EfWorkDayDal();

        public Program AddProgramWithWorkProgram(WorkProgram workProgram)
        {
            var workDay = _workDayDal.Get(x => x.DayName.ToUpper() == workProgram.DayName.ToUpper());
            if (workDay == null)
            {
                workDay = _workDayDal.Add(new WorkDay() { DayName = workProgram.DayName });
            }

            var train = _trainingDal.Get(x => x.TrainingName.ToUpper() == workProgram.TrainName.ToUpper());
            if (train == null)
            {
                train = _trainingDal.Add(new Training() { TrainingName = workProgram.TrainName ,WorkAmount = workProgram.WorkAmount});
            }

            return this.Add(new Program()
            {
                CustomerId = workProgram.CustomerID,
                DayId = workDay.DayId,
                TrainingId = train.TrainingId,
            });
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
                        TrainName = t.TrainingName
                    };
                return result.ToList();
            }
        }

        


    }


}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void get_all()
        {
            EfProgramDal dal = new EfProgramDal();
            var result = dal.GetList();
            Assert.IsTrue(result!=null);
        }

        [TestMethod]
        public void delete_existing_program()
        {
            EfProgramDal dal = new EfProgramDal();
            var deletedValue = dal.Get(x => x.ProgramId == 7);
            dal.Delete(deletedValue);
        }

        [TestMethod]
        public void Add_train()
        {
            EfTrainingDal dal = new EfTrainingDal();
            dal.Add(new Training
            {
                TrainingName = "Test"
            });
           
        }
        [TestMethod]
        public void Add_work_day()
        {
            EfWorkDayDal dal = new EfWorkDayDal();
            dal.Add(new WorkDay()
            {
                DayName = "Test"
            });

        }
    }
}

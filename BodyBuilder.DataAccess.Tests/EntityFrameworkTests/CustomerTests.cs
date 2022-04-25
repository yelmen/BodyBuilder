using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Business.DependencyResolvers.Ninject;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.ComplexTypes;
using BodyBuilder.Entities.Concrete;
using Ninject;

namespace BodyBuilder.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void get_all_returns_all_results()
        {
            EfCustomerDal dal = new EfCustomerDal();
            var result = dal.GetList();
            Assert.AreEqual(2,result.Count);
        }
        [TestMethod]
        public void add_control()
        {
            EfCustomerDal dal = new EfCustomerDal();
            dal.Add(new Customer()
            {
                CoachId = 1,
                CustomerAddress = "Istanbul",
                CustomerAge = 20,
                CustomerSurname = "Kiğılı",
                CustomerPhone = "20202020",
                CustomerWeight = 75.6,
                CustomerSize = 1.87,
                CustomerTc = "13214125123",
                CustomerName = "Murat",
                startDate = DateTime.Now,
                endDate = DateTime.Now,
            });

        }
        [TestMethod]
        public void delete_control()
        {
            EfCustomerDal dal = new EfCustomerDal();
            Customer deletedCustomer = dal.Get(x => x.CustomerId == 4);
            dal.Delete(deletedCustomer);

        }

        [TestMethod]
        public void Kernel_coach_tests()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CoachManager manager = new CoachManager(kernel.Get<ICoachDal>());

            var result = manager.GetById(1);
            Assert.IsTrue(result.CoachName == "mustafa");
        }

        [TestMethod]
        public void Complex_types()
        {
            EfCustomerDal dal = new EfCustomerDal();

            var result = dal.GetPrograms();
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Complex_types_with_customer_id()
        {
            EfCustomerDal dal = new EfCustomerDal();

            var result = dal.GetProgramsByCustomerId(2002);
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void Complex_types_with_customer_id_name()
        {
            EfCustomerDal dal = new EfCustomerDal();

            var result = dal.GetProgramsByCustomerId(2002,"birincigün");
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void Work_day_dal(){
            EfWorkDayDal dal = new EfWorkDayDal();

            var result = dal.Get(x=>x.DayName.ToUpper() == "test".ToUpper());
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Train_dal()
        {
            EfTrainingDal dal = new EfTrainingDal();

            var result = dal.Get(x => x.TrainingName.ToUpper() == "test".ToUpper());
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Add_program()
        {
            EfProgramDal dal = new EfProgramDal();

            var result = dal.AddProgramWithWorkProgram(new WorkProgram()
            {
                CustomerID = 2002,
                DayName = "Pazartesi",
                WorkAmount = "12x5",
                TrainName = "Şınav"
            });
            Assert.IsTrue(result != null);
        }

    }
}

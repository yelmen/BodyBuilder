using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.Business.Abstract;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Business.DependencyResolvers.Ninject;
using Ninject;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.Business.Tests.EntityFramework_Tests
{
    [TestClass]
    public class KernelTests
    {
        [TestMethod]
        public void Kernel_tests()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            UserManager manager = new UserManager(kernel.Get<IUserDal>());
            var result = manager.GetById(1);
            Assert.IsTrue(result.Name=="Gökay");
        }

        [TestMethod]
        public void Kernel_coach_tests()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            EfCoachDal _dal = new EfCoachDal();
            CoachManager manager = new CoachManager(_dal);
            var result = manager.GetById(1);
            Assert.IsTrue(result.CoachName == "mustafa");
        }
        [TestMethod]
        public void Kernel_customer_tests()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>());
            var result = manager.GetById(2);
            Assert.IsTrue(result.CustomerName == "mehmet");
        }

        [TestMethod]
        public void Kernel_customer_tests_id()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>());
            var result = manager.GetProgramsByCustomerId(2002);
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void Kernel_customer_tests_id_name()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>());
            var result2 = manager.GetProgramsByKey("gög");
            var result = manager.GetProgramsByCustomerId(2002,"birincigün");
            Assert.IsTrue(result2.Count == 1);
        }

        [TestMethod]
        public void Kernel_Program_Test_Get_All()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            ProgramManager manager = new ProgramManager(kernel.Get<IProgramDal>());
            var result = manager.GetAll();
            Assert.IsTrue(result!=null);
        }

        [TestMethod]
        public void Beginner_program()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>(), kernel.Get<IProgramDal>(),
                kernel.Get<ITrainDal>());
            var result = manager.Add(new Customer()
            {
                CoachId = 1004,
                CustomerAddress = "b",
                CustomerAge = 19,
                CustomerWeight = 75,
                CustomerSize = 1.80,
                CustomerName = "Mehmet",
                CustomerPhone = "555 555 55 55",
                CustomerSurname = "Lo",
                startDate = DateTime.Now,
                endDate = DateTime.Now,
                CustomerTc = "12345678910"
            });

           // manager.BeginnerProgram(result);
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Body_builder_program()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>(), kernel.Get<IProgramDal>(),
                kernel.Get<ITrainDal>());
            var result = manager.Add(new Customer()
            {
                CoachId = 1004,
                CustomerAddress = "b",
                CustomerAge = 19,
                CustomerWeight = 75,
                CustomerSize = 1.80,
                CustomerName = "Kas",
                CustomerPhone = "555 555 55 55",
                CustomerSurname = "Yapçam",
                startDate = DateTime.Now,
                endDate = DateTime.Now,
                CustomerTc = "12345678911"
            });

           // manager.BodyBuildProgram(result);
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Losing_weight_program()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            CustomerManager manager = new CustomerManager(kernel.Get<ICustomerDal>(), kernel.Get<IProgramDal>(),
                kernel.Get<ITrainDal>());
            var result = manager.Add(new Customer()
            {
                CoachId = 1004,
                CustomerAddress = "b",
                CustomerAge = 19,
                CustomerWeight = 90,
                CustomerSize = 1.80,
                CustomerName = "Kilo vermek",
                CustomerPhone = "555 555 55 55",
                CustomerSurname = "istiom",
                startDate = DateTime.Now,
                endDate = DateTime.Now,
                CustomerTc = "12345678922"
            });

            //manager.LosingWeightProgram(result);
            Assert.IsTrue(result != null);
        }
    }
}

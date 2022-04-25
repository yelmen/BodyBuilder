using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.Business.Concrete.Managers;
using BodyBuilder.Business.DependencyResolvers.Ninject;
using BodyBuilder.DataAccess.Abstract;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;
using Ninject;

namespace BodyBuilder.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void get_all_returns_all_users()
        {
            EfUserDal userDal = new EfUserDal();
            var result = userDal.GetList();

            Assert.AreEqual(1,result.Count);
        }

        

        [TestMethod]
        public void add_added_user()
        {
            EfUserDal userDal = new EfUserDal();
            User addedUser = new User() { Name = "Mehmet", Password = "112233", Surname = "Zego", UserName = "Zigo" };
            userDal.Add(addedUser);
            var result = userDal.Get(x => x.Name == "Mehmet");
            Assert.IsTrue(result!=null);
        }

        [TestMethod]
        public void delete_delete_user()
        {
            EfUserDal userDal = new EfUserDal();
            User deletedUser = userDal.Get(x => x.Name == "Mehmet");
            userDal.Delete(deletedUser);

        }

        [TestMethod]
        public void update_update_user()
        {
            EfUserDal userDal = new EfUserDal();
            User updatedUser = userDal.Get(x => x.UserID == 1);
            updatedUser.Name = "Gökay";
            userDal.Update(updatedUser);
        }

        [TestMethod]
        public void Kernel_tests()
        {
            IKernel kernel = new StandardKernel(new BusinessModule());
            UserManager manager = new UserManager(kernel.Get<IUserDal>());
            var result = manager.GetById(1);
            Assert.IsTrue(result.Name == "Gökay");
        }


        
    }
}

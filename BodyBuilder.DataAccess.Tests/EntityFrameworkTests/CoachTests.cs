using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class CoachTests
    {
        [TestMethod]
        public void Get_all_returns_all_results()
        {
            EfCoachDal dal = new EfCoachDal();
            var result = dal.GetList();
            Assert.AreEqual(2,result.Count);
        }
        [TestMethod]
        public void Add_Control()
        {
            EfCoachDal dal = new EfCoachDal();
            dal.Add(new Coach()
            {
                CoachName = "Hasan Götüne ",
                CoachSurname = "Basan",
                CoachUsername = "gottenyerim",
                CoahPassword = "s2nb3n1"
            });
        }
    }



   
    
}

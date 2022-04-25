using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BodyBuilder.DataAccess.Concrete.EntityFramework.DataAccessLayers;
using BodyBuilder.Entities.Concrete;

namespace BodyBuilder.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class MemberTests
    {
        // member tests
        [TestMethod]
        public void get_all_returns_all_members()
        {
            EfMemberDal memberDal = new EfMemberDal();
            var result = memberDal.GetList(x=>x.UserID == 2);

            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void add_member_adds_member()
        {
            EfMemberDal memberDal = new EfMemberDal();
            var result = memberDal.Add(new Member()
            {
                MemberSize = 180d,
                MemberAddress = "Ankara",
                MemberAge = 21,
                MemberFinishDate = new DateTime(2022, 12, 20),
                MemberStartDate = new DateTime(2023, 12, 20),
                MemberName = "Mustafa",
                MemberSurname = "YELMEN",
                MemberWeight = 80,
                UserID = 2
            });
            Assert.AreEqual(true,result != null);
        }

        [TestMethod]
        public void update_member_updates_member()
        {
            EfMemberDal memberDal = new EfMemberDal();
            var member = memberDal.Get(x => x.MemberID == 7);
            member.MemberAddress = "Ankara Nallıhan";
            memberDal.Update(member);
        }

        [TestMethod]
        public void delete_member_deletes_member()
        {
            EfMemberDal memberDal = new EfMemberDal();
            var member = memberDal.Get(x => x.MemberID == 7);
            memberDal.Delete(member);
        }
    }
}

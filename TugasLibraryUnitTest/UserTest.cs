using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void TestValidUser()
        {
            //Assert.IsTrue(user.IsValidUser("admin", "admin"));
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }
    }
}
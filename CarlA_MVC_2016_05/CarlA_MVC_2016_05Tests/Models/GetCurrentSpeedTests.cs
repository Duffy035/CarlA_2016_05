//Carl Andersson

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarlA_MVC_2016_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlA_MVC_2016_05.Models.Tests
{
    [TestClass()]
    public class GetCurrentSpeedTests
    {
        [TestMethod()]
        public void SpeedTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void GetCurrentSpeed_PositiveValue()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            var actual = getCurrentSpeed.Speed("5", "2");
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCurrentSpeed_BigValue()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            var actual = getCurrentSpeed.Speed("5000", "50");
            var expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void GetCurrentSpeed_Exception()
        {
            GetCurrentSpeed getCurrentSpeed = new GetCurrentSpeed();
            getCurrentSpeed.Speed("0", "0");
        }
    }
}
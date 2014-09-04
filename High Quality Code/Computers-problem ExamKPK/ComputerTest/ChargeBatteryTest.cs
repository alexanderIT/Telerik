using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computers.Interfaces;
using Computers.Components;

namespace ComputerTest
{
    [TestClass]
    public class ChargeBatteryTest
    {
        [TestMethod]
        public void InitiallyTheChargeShouldBe50()
        {
            IBattery batt = new Battery();
            Assert.AreEqual(50, batt.percentagePowerLeft);

        }
        [TestMethod]
        public void IfChargedWithMoreThan100ShouldBe100()
        {
            IBattery batt = new Battery();
            batt.Charge(150);
            Assert.AreEqual(100, batt.percentagePowerLeft); 
        }
        public void IfBigNegativeValueTheChargeShouldBeZero()
        {
            IBattery batt = new Battery();
            batt.Charge(-150);
            Assert.AreEqual(0, batt.percentagePowerLeft);
        }
    }
}

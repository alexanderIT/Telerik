using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computers.Interfaces;
using Computers.Components;

namespace ComputerTest
{
    [TestClass]
    public class CPUSquareMethodTest
    {
        [TestMethod]
        public void CPUType32bitShouldNotSquareBiggerThan500()
        {
            IMemory mem = new Memory(2);
            mem.Save(600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type32bit, 2);           
            Assert.AreEqual("Number too high.", cpu.SquareNumberFromRam());
        }
        [TestMethod]
        public void CPUType32bitShouldNotSquareLesserThanZero()
        {
            IMemory mem = new Memory(2);
            mem.Save(-600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type32bit, 2);
            Assert.AreEqual("Number too low.", cpu.SquareNumberFromRam());
        }
        [TestMethod]
        public void CPUType64bitShouldNotSquareBiggerThan1000()
        {
            IMemory mem = new Memory(2);
            mem.Save(1200);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type64bit, 2);
            Assert.AreEqual("Number too high.", cpu.SquareNumberFromRam());
        }
        [TestMethod]
        public void CPUType64bitShouldNotSquareLesserThanZero()
        {
            IMemory mem = new Memory(2);
            mem.Save(-600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type64bit, 2);
            Assert.AreEqual("Number too low.", cpu.SquareNumberFromRam());
        }
        [TestMethod]
        public void CPUType128bitShouldNotSquareBiggerThan2000()
        {
            IMemory mem = new Memory(2);
            mem.Save(2600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type128bit, 2);
            Assert.AreEqual("Number too high.", cpu.SquareNumberFromRam());
        }
        [TestMethod]
        public void CPUType128bitShouldNotSquareLesserThanZero()
        {
            IMemory mem = new Memory(2);
            mem.Save(-600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type128bit, 2);
            Assert.AreEqual("Number too low.", cpu.SquareNumberFromRam());
        }
    }
}

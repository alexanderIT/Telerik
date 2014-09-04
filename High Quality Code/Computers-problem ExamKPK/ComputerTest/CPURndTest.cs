using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Computers.Interfaces;
using Computers.Components;

namespace ComputerTest
{
    [TestClass]
    public class CPURndTest
    {
        [ExpectedException(typeof(ArgumentException))]
        public void TooBigRangeShouldThrowException()
        {
            IMemory mem = new Memory(2);
            mem.Save(600);
            IVideocard video = new Videocard(Computers.VideocardType.monochrome);
            ICPU cpu = new CPU(mem, video, Computers.CPUType.type32bit, 2);
            cpu.SaveRandomNumberToRam(0,2000000000);
        }
    }
}

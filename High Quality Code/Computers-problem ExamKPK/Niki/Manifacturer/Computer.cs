namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public abstract class Computer : IComputer
    {
        public ICPU CPU { get; set; }

        public IMemory Memory { get; set; }

        public IVideocard Videocard { get; set; }

        public IHarddisk Harddisk { get; set; }

        public Computer(ICPU cpu, IMemory mem, IVideocard video, IHarddisk disk)
        {
            this.CPU = cpu;
            this.Memory = mem;
            this.Videocard = video;
            this.Harddisk = disk;
        }
    }
}

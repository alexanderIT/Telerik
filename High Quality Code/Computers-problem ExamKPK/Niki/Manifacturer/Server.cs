namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Server : Computer
    {
        public Server(ICPU cpu, IMemory mem, IHarddisk disk, IVideocard video) 
            :base(cpu, mem, video, disk)
        {     
  
        }

        public int Process(int value)
        {
            base.Memory.Save(value);
            base.CPU.SquareNumberFromRam();
            return base.Memory.Load();
        }
    }
}

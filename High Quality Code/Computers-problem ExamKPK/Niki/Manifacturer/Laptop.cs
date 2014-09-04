namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Laptop : Computer
    {
        private IBattery Battery { get; set; }

        public Laptop(ICPU cpu, IMemory mem, IHarddisk disk, IVideocard video, IBattery bat) 
            : base(cpu, mem, video, disk)
        {
            this.Battery = bat;
        }

        public void Charge(int percentage)
        {
            this.Battery.Charge(percentage);
            this.Videocard.Print(string.Format("Battery status: {0}%", this.Battery.percentagePowerLeft));
        }
    }
}

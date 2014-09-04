namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBattery
    {
        int percentagePowerLeft {get; set;}

        void Charge(int percentage);
    }
}
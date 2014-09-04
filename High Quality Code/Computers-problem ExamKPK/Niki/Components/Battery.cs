namespace Computers.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Battery : IBattery
    {
        private const int MAX_BATTERY = 100;
        private const int MIN_BATTERY = 0;
        private const int INITIAL_BATTERY_POWER = MAX_BATTERY / 2;

        public Battery() 
        {
            this.percentagePowerLeft = INITIAL_BATTERY_POWER;
        }

        public int percentagePowerLeft
        {
            get;
            set;
        }

        public void Charge(int percentage)
        {
            this.percentagePowerLeft += percentage;
            if (this.percentagePowerLeft > MAX_BATTERY)
            {
                this.percentagePowerLeft = MAX_BATTERY;
            }
            else if (percentagePowerLeft < MIN_BATTERY)
            {
                this.percentagePowerLeft = MIN_BATTERY;
            }
        }
    }
}

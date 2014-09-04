namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class PersonalComputer : Computer
    {
        public PersonalComputer(ICPU cpu, IMemory mem, IHarddisk disk, IVideocard video) 
            : base(cpu, mem, video, disk)
        { 

        }

        public void Play(int guessNumber)
        {
            base.CPU.SaveRandomNumberToRam(1, 10);
            var number = base.Memory.Load();
            if (number != guessNumber)
            {
                base.Videocard.Print(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                base.Videocard.Print("You win!");
            }
        }
    }
}

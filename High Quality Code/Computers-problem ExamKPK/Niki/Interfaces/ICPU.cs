namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Enums;

    public interface ICPU
    {
        IMemory Memory { get;  set; }

        IVideocard Videocard { get; set; }

        int NumberOfCores { get; set; }

        void SaveRandomNumberToRam(int min, int max);

        string SquareNumberFromRam();

        CPUType Type { get; set; }
    }
}
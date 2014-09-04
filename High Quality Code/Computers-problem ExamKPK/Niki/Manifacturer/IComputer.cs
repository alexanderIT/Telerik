namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public interface IComputer
    {
        ICPU CPU { get; set; }

        IMemory Memory { get; set; }

        IVideocard Videocard { get; set; }

        IHarddisk Harddisk { get;  set; }
    }
}

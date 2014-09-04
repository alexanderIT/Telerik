namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IVideocard
    {
        VideocardType Type { get; set; }

        string Print(string text);
    }
}

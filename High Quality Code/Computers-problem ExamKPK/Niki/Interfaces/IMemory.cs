namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMemory
    {
        int Amount { get; set; }

        void Save(int data);

        int Load();
    }
}

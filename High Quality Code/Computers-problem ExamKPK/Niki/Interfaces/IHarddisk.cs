namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Components;

    public interface IHarddisk
    {
        int Capacity { get; set; }

        bool isInRaid { get; set; }

        int hardDrivesInRaid { get; set; }

        List<Harddisk> harddiskCollection { get; set; }

        HarddiskType Type { get; set; }

        SortedDictionary<int, string> Storage { get; set; }

        void SaveData(string data, int address);

        string LoadData(int address);
    }
}

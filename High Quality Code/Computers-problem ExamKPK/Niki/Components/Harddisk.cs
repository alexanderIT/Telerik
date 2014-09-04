namespace Computers.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Harddisk : IHarddisk
    {
        public int Capacity
        {
            set; 
            get;
        }

        public bool isInRaid
        {
            set;
            get;
        }

        public int hardDrivesInRaid
        {
            set;
            get;
        }

        public List<Harddisk> harddiskCollection
        {
            set;
            get;
        }

        public HarddiskType Type
        {
            set;
            get;
        }

        public SortedDictionary<int, string> Storage
        {
            set;
            get;
        }

        public Harddisk(int capacity, HarddiskType type, bool isInRaid)
        {
            this.Capacity = capacity;
            this.Type = type;
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = 0;
            Storage = new SortedDictionary<int, string>();
        }

        public Harddisk(int capacity, HarddiskType type, bool isInRaid, int hardDrivesInRaid, List<Harddisk> harddisksInRaid)
        {
            this.Capacity = harddisksInRaid.First().Capacity;
            this.Type = type;
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            if (isInRaid)
            {
                this.harddiskCollection = harddisksInRaid;            
            }

            Storage = new SortedDictionary<int, string>();
        }

        public void SaveData(string data, int address)
        {
            if (this.isInRaid)
            {
                foreach (var disk in this.harddiskCollection)
                {
                    disk.SaveData(data,address);
                }
            }
            else
            {
                this.Storage[address] = data;
            }
        }

        public string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!this.harddiskCollection.Any())
                {
                    throw new Exception("No hard drive in the RAID array!");
                }

                return this.harddiskCollection.First().LoadData(address);
            }
            else
            {
                return this.Storage[address];
            }
        }
    }
}

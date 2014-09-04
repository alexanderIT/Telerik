namespace Computers.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;
    using Computers.Components;
    using Computers.Enums;

    public class LenovoFactory : IFactory
    {
        private const int Lenovo_LAPTOP_MEMORY = 16;
        private const int Lenovo_LAPTOP_CORES_COUNT = 2;
        private const CPUType Lenovo_LAPTOP_CPU_TYPE = CPUType.type64bit;
        private const int Lenovo_LAPTOP_HARDDISK_CAPACITY = 1000;
        private const bool Lenovo_LAPTOP_HARDDISK_RAID = false;
        private const VideocardType Lenovo_LAPTOP_VIDEOCARD_TYPE = VideocardType.colorful;

        private const int Lenovo_SERVER_MEMORY = 8;
        private const int Lenovo_SERVER_CORES_COUNT = 2;
        private const CPUType Lenovo_SERVER_CPU_TYPE = CPUType.type128bit;
        private const int Lenovo_SERVER_HARDDISK_CAPACITY = 0;
        private const bool Lenovo_SERVER_HARDDISK_RAID = true;
        private const int Lenovo_SERVER_HARDDISK_RAID_COUNT = 2;
        private const int Lenovo_SERVER_HARDDISK_RAID_CAPACITY = 500;
        private const VideocardType Lenovo_SERVER_VIDEOCARD_TYPE = VideocardType.monochrome;

        private const int Lenovo_PC_MEMORY = 4;
        private const int Lenovo_PC_CORES_COUNT = 2;
        private const CPUType Lenovo_PC_CPU_TYPE = CPUType.type64bit;
        private const int Lenovo_PC_HARDDISK_CAPACITY = 2000;
        private const bool Lenovo_PC_HARDDISK_RAID = false;
        private const VideocardType Lenovo_PC_VIDEOCARD_TYPE = VideocardType.monochrome;

        public IComputer ManufactureComputer(ComputerType type)
        {
            IComputer newComputer;
            IMemory memory;
            IVideocard video;
            ICPU cpu;
            IHarddisk disk;

            switch (type)
            {
                case ComputerType.PC:
                    memory = new Memory(Lenovo_PC_MEMORY);
                    video = new Videocard(Lenovo_PC_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, Lenovo_PC_CPU_TYPE, Lenovo_PC_CORES_COUNT);
                    disk = new Harddisk(Lenovo_PC_HARDDISK_CAPACITY, HarddiskType.HDD, Lenovo_PC_HARDDISK_RAID);
                    newComputer = new PersonalComputer(cpu, memory, disk, video);
                    return newComputer;
                case ComputerType.Laptop:
                    memory = new Memory(Lenovo_LAPTOP_MEMORY);
                    video = new Videocard(Lenovo_LAPTOP_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, Lenovo_LAPTOP_CPU_TYPE, Lenovo_LAPTOP_CORES_COUNT);
                    disk = new Harddisk(Lenovo_LAPTOP_HARDDISK_CAPACITY, HarddiskType.HDD, Lenovo_LAPTOP_HARDDISK_RAID);
                    newComputer = new Laptop(cpu, memory, disk, video, new Battery());
                    return newComputer;
                case ComputerType.Server:
                    memory = new Memory(Lenovo_SERVER_MEMORY);
                    video = new Videocard(Lenovo_SERVER_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, Lenovo_SERVER_CPU_TYPE, Lenovo_SERVER_CORES_COUNT);

                    var disks = new List<Harddisk>();
                    for (int i = 0; i < Lenovo_SERVER_HARDDISK_RAID_COUNT; i++)
                    {
                        disks.Add(new Harddisk(Lenovo_SERVER_HARDDISK_RAID_CAPACITY, HarddiskType.HDD, false));
                    }

                    disk = new Harddisk(Lenovo_SERVER_HARDDISK_CAPACITY, HarddiskType.HDD, Lenovo_PC_HARDDISK_RAID, Lenovo_SERVER_HARDDISK_RAID_COUNT, disks);
                    newComputer = new Server(cpu, memory, disk, video);
                    return newComputer;
                default:
                    throw new Exception("Invalid computer type!");
            }
        }
    }
}

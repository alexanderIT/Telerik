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

    public class DellFactory : IFactory
    {
        private const int DELL_LAPTOP_MEMORY = 8;
        private const int DELL_LAPTOP_CORES_COUNT = 4;
        private const CPUType DELL_LAPTOP_CPU_TYPE = CPUType.type32bit;
        private const int DELL_LAPTOP_HARDDISK_CAPACITY = 1000;
        private const bool DELL_LAPTOP_HARDDISK_RAID = false;
        private const VideocardType DELL_LAPTOP_VIDEOCARD_TYPE = VideocardType.colorful;

        private const int DELL_SERVER_MEMORY = 64;
        private const int DELL_SERVER_CORES_COUNT = 8;
        private const CPUType DELL_SERVER_CPU_TYPE = CPUType.type64bit;
        private const int DELL_SERVER_HARDDISK_CAPACITY = 0;
        private const bool DELL_SERVER_HARDDISK_RAID = true;
        private const int DELL_SERVER_HARDDISK_RAID_COUNT = 2;
        private const int DELL_SERVER_HARDDISK_RAID_CAPACITY = 2000;
        private const VideocardType DELL_SERVER_VIDEOCARD_TYPE = VideocardType.monochrome;

        private const int DELL_PC_MEMORY = 8;
        private const int DELL_PC_CORES_COUNT = 4;
        private const CPUType DELL_PC_CPU_TYPE = CPUType.type64bit;
        private const int DELL_PC_HARDDISK_CAPACITY = 1000;
        private const bool DELL_PC_HARDDISK_RAID = false;
        private const VideocardType DELL_PC_VIDEOCARD_TYPE = VideocardType.colorful;

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
                    memory = new Memory(DELL_PC_MEMORY);
                    video = new Videocard(DELL_PC_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, DELL_PC_CPU_TYPE, DELL_PC_CORES_COUNT);
                    disk = new Harddisk(DELL_PC_HARDDISK_CAPACITY, HarddiskType.HDD, DELL_PC_HARDDISK_RAID);
                    newComputer = new PersonalComputer(cpu, memory, disk, video);
                    return newComputer;
                case ComputerType.Laptop:
                    memory = new Memory(DELL_LAPTOP_MEMORY);
                    video = new Videocard(DELL_LAPTOP_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, DELL_LAPTOP_CPU_TYPE, DELL_LAPTOP_CORES_COUNT);
                    disk = new Harddisk(DELL_LAPTOP_HARDDISK_CAPACITY, HarddiskType.HDD, DELL_LAPTOP_HARDDISK_RAID);
                    newComputer = new Laptop(cpu, memory, disk, video, new Battery());
                    return newComputer;
                case ComputerType.Server:
                    memory = new Memory(DELL_SERVER_MEMORY);
                    video = new Videocard(DELL_SERVER_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, DELL_SERVER_CPU_TYPE, DELL_SERVER_CORES_COUNT);

                    var disks = new List<Harddisk>();
                    for (int i = 0; i < DELL_SERVER_HARDDISK_RAID_COUNT; i++)
                    {
                        disks.Add(new Harddisk(DELL_SERVER_HARDDISK_RAID_CAPACITY, HarddiskType.HDD, false));
                    }

                    disk = new Harddisk(DELL_SERVER_HARDDISK_CAPACITY, HarddiskType.HDD, DELL_PC_HARDDISK_RAID, DELL_SERVER_HARDDISK_RAID_COUNT, disks);
                    newComputer = new Server(cpu, memory, disk, video);
                    return newComputer;
                default:
                    throw new Exception("Invalid computer type!");
            }
        }
    }
}

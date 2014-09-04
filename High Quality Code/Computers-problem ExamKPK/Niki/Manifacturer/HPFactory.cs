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

    public class HPFactory : IFactory
    {
        private const int HP_LAPTOP_MEMORY = 4;
        private const int HP_LAPTOP_CORES_COUNT = 2;
        private const CPUType HP_LAPTOP_CPU_TYPE = CPUType.type64bit;
        private const int HP_LAPTOP_HARDDISK_CAPACITY = 500;
        private const bool HP_LAPTOP_HARDDISK_RAID = false;
        private const VideocardType HP_LAPTOP_VIDEOCARD_TYPE = VideocardType.colorful;

        private const int HP_SERVER_MEMORY = 32;
        private const int HP_SERVER_CORES_COUNT = 4;
        private const CPUType HP_SERVER_CPU_TYPE = CPUType.type32bit;
        private const int HP_SERVER_HARDDISK_CAPACITY = 0;
        private const bool HP_SERVER_HARDDISK_RAID = true;
        private const int HP_SERVER_HARDDISK_RAID_COUNT = 2;
        private const int HP_SERVER_HARDDISK_RAID_CAPACITY = 1000;
        private const VideocardType HP_SERVER_VIDEOCARD_TYPE = VideocardType.monochrome; 

        private const int HP_PC_MEMORY = 2;
        private const int HP_PC_CORES_COUNT = 2;
        private const CPUType HP_PC_CPU_TYPE = CPUType.type32bit;
        private const int HP_PC_HARDDISK_CAPACITY = 500;
        private const bool HP_PC_HARDDISK_RAID = false;
        private const VideocardType HP_PC_VIDEOCARD_TYPE = VideocardType.colorful;

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
                    memory = new Memory(HP_PC_MEMORY);
                    video = new Videocard(HP_PC_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, HP_PC_CPU_TYPE, HP_PC_CORES_COUNT);
                    disk = new Harddisk(HP_PC_HARDDISK_CAPACITY, HarddiskType.HDD, HP_PC_HARDDISK_RAID);
                    newComputer = new PersonalComputer(cpu, memory, disk, video);
                    return newComputer;
                case ComputerType.Laptop:
                    memory = new Memory(HP_LAPTOP_MEMORY);
                    video = new Videocard(HP_LAPTOP_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, HP_LAPTOP_CPU_TYPE, HP_LAPTOP_CORES_COUNT);
                    disk = new Harddisk(HP_LAPTOP_HARDDISK_CAPACITY, HarddiskType.HDD, HP_LAPTOP_HARDDISK_RAID);
                    newComputer = new Laptop(cpu, memory, disk, video, new Battery());
                    return newComputer;
                case ComputerType.Server:
                    memory = new Memory(HP_SERVER_MEMORY);
                    video = new Videocard(HP_SERVER_VIDEOCARD_TYPE);
                    cpu = new CPU(memory, video, HP_SERVER_CPU_TYPE, HP_SERVER_CORES_COUNT);

                    var disks = new List<Harddisk>();
                    for (int i = 0; i < HP_SERVER_HARDDISK_RAID_COUNT; i++)
		        	{
			            disks.Add(new Harddisk(HP_SERVER_HARDDISK_RAID_CAPACITY, HarddiskType.HDD, false));
			        }

                    disk = new Harddisk(HP_SERVER_HARDDISK_CAPACITY, HarddiskType.HDD, HP_PC_HARDDISK_RAID, HP_SERVER_HARDDISK_RAID_COUNT, disks);        
                    newComputer = new Server(cpu, memory, disk, video);
                    return newComputer;
                default:
                    throw new Exception("Invalid computer type!");
            }      
        }
    }
}

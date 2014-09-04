namespace Computers.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;
    using Computers.Enums;

    public class CPU : ICPU
    {
        private const int MIN_VALUE_TO_SQUARE = 0;
        private const int MAX_VALUE_TO_SQUARE_32BIT = 500;
        private const int MAX_VALUE_TO_SQUARE_64BIT = 1000;
        private const int MAX_VALUE_TO_SQUARE_128BIT = 2000;

        public CPU(IMemory mem, IVideocard video, CPUType type, int numberOfCores)
        {
            this.Memory = mem;
            this.Videocard = video;
            this.Type = type;
            this.NumberOfCores = numberOfCores;
        }

        public IMemory Memory
        {
            get;
            set;
        }

        public IVideocard Videocard
        {
            get;
            set;
        }

        public int NumberOfCores
        {
            set;
            get;
        }

        public CPUType Type
        {
            set;
            get;
        }

        public void SaveRandomNumberToRam(int min, int max)
        {
            Random randomNumberGenerator = new Random();
            int numberToSave;
            try
            {
                numberToSave = randomNumberGenerator.Next(min, max);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Fatal Error");
                return;
            }

            this.Memory.Save(numberToSave);
        }

        public string SquareNumberFromRam() 
        {
            int maxValue = 0;
            if(this.Type == CPUType.type32bit)
            {
                maxValue = MAX_VALUE_TO_SQUARE_32BIT;
            }
            else if (this.Type == CPUType.type64bit)
            {
                maxValue = MAX_VALUE_TO_SQUARE_64BIT;
            }
            else if (this.Type == CPUType.type128bit)
            {
                maxValue = MAX_VALUE_TO_SQUARE_128BIT;
            }
            else
            {
                throw new Exception("Invalid CPU Type!");
            }

            int value = this.Memory.Load();
            if (value < MIN_VALUE_TO_SQUARE)
            {
                return this.Videocard.Print("Number too low.");
            }
            else if (value > maxValue)
            {
                return this.Videocard.Print("Number too high.");
            }
            else
            {
                int valueSquared = value * value;
               
                this.Memory.Save(valueSquared);
                return this.Videocard.Print(string.Format("Square of {0} is {1}.", value, valueSquared));
            }
        }
    }
}

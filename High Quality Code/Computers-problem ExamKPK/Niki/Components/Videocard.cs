namespace Computers.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Videocard : IVideocard
    {
        private ConsoleColor printingColor;

        public Videocard(VideocardType type)
        {
            this.Type = type;
            switch (type) 
            {
                case VideocardType.colorful:
                    printingColor = ConsoleColor.Green;
                    break;
                case VideocardType.monochrome:
                    printingColor = ConsoleColor.Gray;
                    break;
            }
        }

        public VideocardType Type
        {
            get;
            set;
        }

        public string Print(string text)
        {
            Console.ForegroundColor = printingColor;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
            return text;
        }
    }
}

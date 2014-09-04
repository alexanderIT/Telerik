namespace Computers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using Computers.Interfaces;
    using Computers.Enums;
    using Computers.Manifacturer;

    public class ComputersEntryPoint
    {
        public static void Main()
        {
            var manufacturer = Console.ReadLine();
            PersonalComputer pc;
            Laptop laptop;
            Server server;

            if (manufacturer == "HP")
            {
                IFactory HP = new HPFactory();
                pc = (PersonalComputer)HP.ManufactureComputer(ComputerType.PC);
                laptop = (Laptop)HP.ManufactureComputer(ComputerType.Laptop);
                server = (Server)HP.ManufactureComputer(ComputerType.Server);
            }
            else if (manufacturer == "Dell")
            {
                IFactory DELL = new HPFactory();
                pc = (PersonalComputer)DELL.ManufactureComputer(ComputerType.PC);
                laptop = (Laptop)DELL.ManufactureComputer(ComputerType.Laptop);
                server = (Server)DELL.ManufactureComputer(ComputerType.Server);
            }
            else if (manufacturer == "Lenovo")
            {
                IFactory Lenovo = new LenovoFactory();
                pc = (PersonalComputer)Lenovo.ManufactureComputer(ComputerType.PC);
                laptop = (Laptop)Lenovo.ManufactureComputer(ComputerType.Laptop);
                server = (Server)Lenovo.ManufactureComputer(ComputerType.Server);
            }
            else
            {
                throw new Exception("Invalid manufacturer!");
            }
     
            while (true)
            {
                var lineFromConsole = Console.ReadLine();

                if (lineFromConsole == null || lineFromConsole.StartsWith("Exit"))
                {
                    break;
                }

                var lineFromConsoleSplited = lineFromConsole.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (lineFromConsoleSplited.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");     
                }

                var command = lineFromConsoleSplited[0];
                var argument = int.Parse(lineFromConsoleSplited[1]);
             
                if (command == "Charge")
                {
                    laptop.Charge(argument);
                }
                else if (command == "Process")
                {
                    server.Process(argument);
                }
                else if (command == "Play")
                {
                    pc.Play(argument); 
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                } 
            }
        }
    }
}
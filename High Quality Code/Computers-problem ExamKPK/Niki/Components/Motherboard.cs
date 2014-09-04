namespace Computers.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Computers.Interfaces;

    public class Motherboard : IMotherboard
    {
        private IMemory Memory {  get;  set; }

        private IVideocard Videocard {  get;  set; }

        public Motherboard(IMemory memory, IVideocard videocard)
        {
            this.Memory = memory;
            this.Videocard = videocard;
        }

        public void SaveToRam(int value)
        {
            this.Memory.Save(value);
        }

        public int LoadFromRam()
        {
            int loadedValue = this.Memory.Load();
            return loadedValue;
        }

        public void DrawOnVideoCard(string text)
        {
            this.Videocard.Print(text);
        }
    }
}

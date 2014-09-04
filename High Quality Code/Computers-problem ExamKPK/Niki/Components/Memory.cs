namespace Computers.Components
{
    using Computers.Interfaces;

    public class Memory : IMemory
    {   
        public Memory(int amount) 
        {
            this.Amount = amount;
        }

        private int Value;

        public int Amount
        {
            get;
            set;
        }
     
        public void Save(int value)
        {
            this.Value = value;   
        }

        public int Load()
        {
            return Value;
        }
    }
}
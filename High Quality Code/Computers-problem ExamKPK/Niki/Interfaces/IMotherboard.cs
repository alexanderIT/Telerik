namespace Computers.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is motherboard interface. His main functionality is to Load and Save data to RAM 
    /// and Print data on the videocard. 
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// Method used to save a single value to the RAM memory. No return value.
        /// </summary>
        /// <param name="value">Value to save</param>
        void SaveToRam(int value);

        /// <summary>
        /// Method used to load a single value from the RAM memory.
        /// </summary>
        /// <returns> Integer value, read from the RAM.</returns>
        int LoadFromRam();

        /// <summary>
        /// Method used to print messege to the videocard
        /// </summary>
        /// <param name="text">Your message as string</param>
        void DrawOnVideoCard(string text);
    }
}

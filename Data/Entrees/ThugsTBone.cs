using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a Tbone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 6.44; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 982; } }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { get { return new List<string>(); } }

        /// <summary>
        /// Function that returns the name of the entree
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}

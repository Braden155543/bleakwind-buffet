using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents cheese grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// sets the private fields to the default values
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// returns the price of the side
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    return 1.22;
                }
                else if (size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }
            }
        }

        /// <summary>
        /// returns the amount of calories
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    return 105;
                }
                else if (size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
                }
            }
        }

        /// <summary>
        /// getter/setter for the size
        /// </summary>
        public Size Size { get { return size; } set { size = value; } }

        /// <summary>
        /// returns a new list since there are no special instructions
        /// </summary>
        public List<string> SpecialInstructions { get { return new List<string>(); } }

        /// <summary>
        /// returns the name and size of the side
        /// </summary>
        /// <returns>name and size as a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size.ToString());
            sb.Append(" Mad Otar Grits");
            return sb.ToString();
        }
    }
}

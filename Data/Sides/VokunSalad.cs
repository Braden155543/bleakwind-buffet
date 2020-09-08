using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// class that represents a fruit salad
    /// </summary>
    public class VokunSalad
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
                    return .93;
                }
                else if (size == Size.Medium)
                {
                    return 1.28;
                }
                else if (size == Size.Large)
                {
                    return 1.82;
                }
                else throw new NotImplementedException($"{size} is not small, medium or large");
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
                    return 41;
                }
                else if (size == Size.Medium)
                {
                    return 52;
                }
                else if (size == Size.Large)
                {
                    return 73;
                }
                else throw new NotImplementedException($"{size} is not small, medium or large");
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
            sb.Append(" Vokun Salad");
            return sb.ToString();
        }
    }
}

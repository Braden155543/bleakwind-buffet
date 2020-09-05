using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents water
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// sets the private fields to their default values
        /// </summary>
        private bool ice = true;
        private Size size = Size.Small;
        private bool lemon = false;

        /// <summary>
        /// Determines whether ice is present
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Contains the size of the soda
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Determines whether the lemon is present
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 0; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 0; } }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions {
            get 
            {
                List<string> list = new List<string>();
                if (!Ice)
                {
                    list.Add("Hold ice");
                }
                if (Lemon)
                {
                    list.Add("Add lemon");
                }

                return list;
            }
        }

        /// <summary>
        /// returns the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append(" Warrior Water");
            return sb.ToString();
        }
    }
}

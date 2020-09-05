using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents coffee
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// sets the private fields to their default values
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;
        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// Determines whether ice is present
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Contains the size of the coffee
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Determines whether cream is present
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// Determines whether the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { 
            get 
            {
                if (size == Size.Small)
                {
                    return .75;
                }
                else if (size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { 
            get 
            {
                if (size == Size.Small)
                {
                    return 7;
                }
                else if (size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            } 
        }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
            get 
            {
                List<string> list = new List<string>();
                if (Ice)
                {
                    list.Add("Add ice");
                }
                if (RoomForCream)
                {
                    list.Add("Add cream");
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
            sb.Append(" Candlehearth Coffee");
            return sb.ToString();
        }
    }
}

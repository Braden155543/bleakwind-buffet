using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents apple juice
    /// </summary>
    public class AretinoAppleJuice
    {
        /// <summary>
        /// sets the private fields to their default values
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;

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
        /// contains the price
        /// </summary>
        public double Price { 
            get 
            {
                if (size == Size.Small)
                {
                    return .62;
                }
                else if (size == Size.Medium)
                {
                    return .87;
                }
                else
                {
                    return 1.01;
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
                    return 44;
                }
                else if (size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
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
            sb.Append(" Aretino Apple Juice");
            return sb.ToString();
        }
    }
}

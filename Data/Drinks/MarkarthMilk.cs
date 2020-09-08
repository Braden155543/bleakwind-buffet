using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents milk
    /// </summary>
    public class MarkarthMilk
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
                    return 1.05;
                }
                else if (size == Size.Medium)
                {
                    return 1.11;
                }
                else if (size == Size.Large)
                {
                    return 1.22;
                }
                else throw new NotImplementedException($"{size} is not small, medium or large");
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
                    return 56;
                }
                else if (size == Size.Medium)
                {
                    return 72;
                }
                else if (size == Size.Large)
                {
                    return 93;
                }
                else throw new NotImplementedException($"{size} is not small, medium or large");
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
            sb.Append(" Markarth Milk");
            return sb.ToString();
        }
    }
}

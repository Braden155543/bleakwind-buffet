using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// class that represents soda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// sets the private fields to their default values
        /// </summary>
        private bool ice = false;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

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
        /// Contains the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor 
        { 
            get { return flavor; } 
            set { flavor = value; } 
        }

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { 
            get
            {
                if (size == Size.Small)
                {
                    return 1.42;
                }
                else if (size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
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
                    return 117;
                }
                else if (size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
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
            sb.Append(" ");
            sb.Append(Flavor);
            sb.Append(" Sailor Soda");
            return sb.ToString();
        }
    }
}

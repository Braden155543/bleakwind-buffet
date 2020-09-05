using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a philly cheesesteak sandwhich
    /// </summary>
    public class PhillyPoacher
    {
        /// <summary>
        /// sets the default values for the private fields
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 7.23; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 784; } }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
            get
            {
                List<string> list = new List<string>();
                if (!Sirloin)
                {
                    list.Add("Hold sirloin");
                }
                if (!Onion)
                {
                    list.Add("Hold onions");
                }
                if (!Roll)
                {
                    list.Add("Hold roll");
                }

                return list;
            }
        }

        /// <summary>
        /// Determines whether the sirloin is present
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// Determines whether onions are present
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Determines whether the roll is present
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Function that returns the name of the entree
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}

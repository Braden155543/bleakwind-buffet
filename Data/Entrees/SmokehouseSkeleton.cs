using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a breakfast combo
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// sets the default values for the private variables
        /// </summary>
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 5.62; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 602; } }

        /// <summary>
        /// Determines whether the sausage is present
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        /// Determines whether the egg is present
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Determines whether the hashbrowns are present
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        /// <summary>
        /// Determines whether the pancake is present
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
            get
            {
                List<string> list = new List<string>();
                if (!SausageLink)
                {
                    list.Add("Hold sausage");
                }
                if (!Egg)
                {
                    list.Add("Hold eggs");
                }
                if (!HashBrowns)
                {
                    list.Add("Hold hash browns");
                }
                if (!Pancake)
                {
                    list.Add("Hold pancakes");
                }

                return list;
            }
        }

        /// <summary>
        /// Function that returns the name of the entree
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}

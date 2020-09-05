using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents a double burger
    /// </summary>
    public class DoubleDraugr
    {
        /// <summary>
        /// sets the default values for the private variables
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 7.32; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 843; } }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
            get 
            {
                List<string> list = new List<string>();
                if (!Bun)
                {
                    list.Add("Hold bun");
                }
                if (!Ketchup)
                {
                    list.Add("Hold ketchup");
                }
                if (!Mustard)
                {
                    list.Add("Hold mustard");
                }
                if (!Pickle)
                {
                    list.Add("Hold pickle");
                }
                if (!Cheese)
                {
                    list.Add("Hold cheese");
                }
                if (!Tomato)
                {
                    list.Add("Hold tomato");
                }
                if (!Lettuce)
                {
                    list.Add("Hold lettuce");
                }
                if (!Mayo)
                {
                    list.Add("Hold mayo");
                }

                return list;
            }
        }

        /// <summary>
        /// Determines whether the bun is present
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// Determines whether ketchup is present
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Determines whether mustard is present
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Determines whether pickles are present
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Determines whether cheese is present
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Determines whether tomatoes are present
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Determines whether lettuce is present
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// Determines whether mayo is present
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Function that returns the name of the entree
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}

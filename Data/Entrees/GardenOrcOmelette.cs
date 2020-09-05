using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// class that represents an omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /// <summary>
        /// sets the default values for the private variables
        /// </summary>
        private bool brocoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// contains the price
        /// </summary>
        public double Price { get { return 4.57; } }

        /// <summary>
        /// contains the amount of calories
        /// </summary>
        public uint Calories { get { return 404; } }

        /// <summary>
        /// Contains the special instructions for the order
        /// </summary>
        public List<string> SpecialInstructions { 
            get 
            {
                List<string> list = new List<string>();
                if (!Brocoli)
                {
                    list.Add("Hold brocoli");
                }
                if (!Mushrooms)
                {
                    list.Add("Hold mushrooms");
                }
                if (!Tomato)
                {
                    list.Add("Hold tomato");
                }
                if (!Cheddar)
                {
                    list.Add("Hold cheddar");
                }

                return list;
            }
        }

        /// <summary>
        /// Determines whether the pancake is present
        /// </summary>
        public bool Brocoli
        {
            get { return brocoli; }
            set { brocoli = value; }
        }

        /// <summary>
        /// Determines whether the pancake is present
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        /// <summary>
        /// Determines whether the pancake is present
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Determines whether the pancake is present
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Function that returns the name of the entree
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}

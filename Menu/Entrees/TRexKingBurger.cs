﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        private bool bun = true;

        private bool lettuce = true;

        private bool tomato = true;

        private bool onion = true;

        private bool pickle = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool mayo = true;

        public double Price { get; set; }

        public int Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Steakburger Pattie",
                    "Steakburger Pattie", "Lettuce", "Tomato", "Onion", "Pickle", "Ketchup", "Mustard", "Mayo" };
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}

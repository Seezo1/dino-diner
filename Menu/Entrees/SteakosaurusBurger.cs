using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;

        private bool pickle = true;

        private bool ketchup = true;

        private bool mustard = true;

        public double Price { get; set; }

        public int Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Pickle", "Ketchup",
                    "Mustard" };
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.bun = false;
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
    }
}

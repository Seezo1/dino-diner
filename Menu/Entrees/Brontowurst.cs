using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        public bool bun = true;

        public bool peppers = true;

        public bool onions = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                if (bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}

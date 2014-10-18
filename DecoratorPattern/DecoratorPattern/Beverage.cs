using System;

namespace DecoratorPattern
{   
    /// <summary>
    /// SuperClass Beverage.
    /// </summary>
    public abstract class Beverage
    {   
        protected int Cost;
        public string description = "Unknown description";

        public Beverage()
        {

        }

        public int cost() {
            return Cost;
        }

        public void Display() {

            Console.WriteLine(this.description + ":" + cost());

        }

    }
    /// <summary>
    /// Espresso.
    /// </summary>
    public class Espresso : Beverage {
    

        public Espresso() {
            description = "Espresso";
            Cost = 199;
        }

    }

    /// <summary>
    /// HouseBlend.
    /// </summary>
    public class HouseBlend : Beverage {


        public HouseBlend() {
            description = "House Blend Cofee";
            Cost = 89;
        }

    }

    /// <summary>
    /// DarkRoast.
    /// </summary>
    public class DarkRoast : Beverage {


        public DarkRoast() {

            description = "Dark Roast Cofee";
            Cost = 99;

        }

    }

    /// <summary>
    /// Decaf.
    /// </summary>
    public class Decaf : Beverage {


        public Decaf() {

            description = "Decaf Cofee";
            Cost = 105;

        }

    }
}


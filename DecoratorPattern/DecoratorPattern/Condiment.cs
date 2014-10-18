using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Condiment decorator.
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator()
        {
        }

        //public abstract string getDescription();
    }

    /// <summary>
    /// Mocha.
    /// </summary>
    public class Mocha : CondimentDecorator
    {




        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.Cost = 20 + beverage.cost();
            this.description = beverage.description + ", Mocha";
        }


    }

    /// <summary>
    /// Soy.
    /// </summary>
    public class Soy : CondimentDecorator
    {

        //Beverage beverage;


        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.Cost = 15 + beverage.cost();
            this.description = beverage.description + ", Soy";
        }

       
    }

    /// <summary>
    /// Whip.
    /// </summary>
    public class Whip : CondimentDecorator
    {

        // Beverage beverage;


        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.Cost = 10 + +beverage.cost();
            this.description = beverage.description + ", Whip";
        }

        public double cost()
        {
            return this.Cost + beverage.cost();
        }
    }
}


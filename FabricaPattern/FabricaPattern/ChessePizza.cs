using System;

namespace FabricaPattern
{
    public class PushinPizza : Pizza
    {
        protected PushinPizza()
        {
            this.Base = "Fat";
            toppings.Add("Spice");
        }

        public override void cut() {
            Console.WriteLine("Square cutting");

        }
    }

    public class CheesePusingPizza : PushinPizza 
    {
        public CheesePusingPizza () {

            this.Name =  " Cheese Pushing Pizza";
            this.Souce = " Cheese Souce ";
        }
    }

    public class CandyPusingPizza : PushinPizza 
    {
        public CandyPusingPizza () {

            this.Name =  " Candy Pizza";
            this.Souce = " Candy Special Souce ";
        }
    }

}


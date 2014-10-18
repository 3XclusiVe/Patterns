using System;

namespace DecoratorPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {   
            Beverage expresso = new Espresso();
            expresso.Display();
            Beverage dark = new DarkRoast();
            dark = new Soy(dark);
            dark = new Mocha(dark);
            dark.Display();

            Beverage House = new HouseBlend();
            House = new Soy(House);
            House = new Whip(House);
            House.Display();
        }
    }
}

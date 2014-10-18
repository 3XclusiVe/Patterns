using System;

namespace FabricaPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ItalianoFab Italio = new ItalianoFab();
            PushinFab Push = new PushinFab();

            Italio.orderPizza("Cheese");
            Console.WriteLine();
            Push.orderPizza("Candy");
            Console.WriteLine();
            Push.orderPizza("Cheese");
            Console.WriteLine();
            Italio.orderPizza("Candy");
        }
    }
}

using System;

namespace IncapsulationOfMethod
{
    public class Tea : CaffeineBeverage
    {
        public Tea()
        {
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void  AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}


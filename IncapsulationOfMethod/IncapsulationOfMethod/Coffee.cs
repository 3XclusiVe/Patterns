using System;
using System.Runtime.InteropServices;

namespace IncapsulationOfMethod
{
    public class Coffee : CaffeineBeverage
    {
        public Coffee()
        {

        }

        public override void  Brew()
        {
            print("Dripping coffee trough filter");
        }

        public override void  AddCondiments()
        {
            print("Add sugar and milk");
        }

        private void print(string String)
        {
            Console.WriteLine(String);
        }
    }
}


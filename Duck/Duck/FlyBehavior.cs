using System;

namespace Duck
{
    public interface FlyBehavior
    {
         void fly();
    }

    public class FlyWithWings : FlyBehavior {

        public void fly() {
            Console.WriteLine("Im flying");
        }
    }

    public class FlyNoWay : FlyBehavior {

        public void fly() {
            Console.WriteLine("I cant fly");
        }
    }

    public class FlyRocketPowered : FlyBehavior {

        public void fly() {
            Console.WriteLine("I am flying with a rocket");
        }

    }
}


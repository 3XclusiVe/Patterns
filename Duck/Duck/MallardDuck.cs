using System;

namespace Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void  Display() {
            Console.WriteLine("i am real mallard duck");
        }
    }
}


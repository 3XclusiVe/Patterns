using System;

namespace Duck
{
    public interface QuackBehavior
    {
        void quack();
    }

    public class Quack : QuackBehavior {

        public void quack() {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : QuackBehavior {

        public void quack() {
            Console.WriteLine("<Silence>");
        }
    }

    public class Squeak : QuackBehavior {

        public void quack() {
            Console.WriteLine("Squeak");
        }
    }
}


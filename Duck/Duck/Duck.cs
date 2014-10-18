using System;

namespace Duck
{
    public abstract class Duck()
    {   
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;



        public abstract void Display();

        public void peformFly() {
            flyBehavior.fly();
        }

        public void peformQuack() {
            quackBehavior.quack();
        }

        public void swim() {
            Console.WriteLine("All ducks swim");
        }

        public void setFlyBehavior (FlyBehavior fb) {
            flyBehavior = fb;
        }

        public void setQuackBehavior (QuackBehavior qb) {
            quackBehavior = qb;
        }
    }
}


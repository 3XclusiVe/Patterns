using System;

namespace Duck
{
    class MainClass
    {
        public static void Main(string[] args)
        {   
            Duck model = new ModelDuck();

            model.peformFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.peformFly();
            model.peformQuack();
            model.setQuackBehavior(new Squeak());
        }
    }
}

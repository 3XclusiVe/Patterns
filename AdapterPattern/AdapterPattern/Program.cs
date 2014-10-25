using System;

namespace AdapterPattern
{
    /// <summary>
    /// Позволяет вызывать методы интерфейса Tyrkey через interface Duck
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            WildTurkey turkey = new WildTurkey();
            MallardDuck duck = new MallardDuck();
            TurkeyAdapter Adapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Turkey:");
            turkey.fly();
            turkey.gobble();

            Console.WriteLine("Duck:");

            testDuck(duck);

            Console.WriteLine("Adapter:");


            testDuck(Adapter);
      
        }

        public static void testDuck(Duck duck)
        {
            duck.fly();
            duck.quack();
        }
    }
}

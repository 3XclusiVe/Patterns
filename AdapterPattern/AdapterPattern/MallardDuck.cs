using System;

namespace AdapterPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
        }

        #region Duck implementation

        public void quack()
        {
            Console.WriteLine("quack");
        }

        public void fly()
        {
            Console.WriteLine("fly");
        }

        #endregion
    }
}


using System;

namespace AdapterPattern
{
    public class WildTurkey : Turkey
    {
        public WildTurkey()
        {

        }

        #region Turkey implementation

        public void gobble()
        {
            Console.WriteLine("goooble gooble");
        }

        public void fly()
        {
            Console.WriteLine("fly short distance");
        }

        #endregion
    }
}


using System;

namespace AdapterPattern
{
    public class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        #region Duck implementation

        public void quack()
        {
            turkey.gobble();
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }

        #endregion
    }
}


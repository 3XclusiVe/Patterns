using System;

namespace Comand
{
    /// <summary>
    /// Исполнитель 
    /// </summary>
    public class Light
    {
        public Light()
        {
        }

        public virtual void On()
        {
            Console.WriteLine("Light is On");
        }

        public virtual void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}


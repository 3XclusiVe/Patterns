using System;

namespace Comand
{
    public class GarageDoor
    {
        public GarageDoor()
        {

        }

        public void up()
        {
            print("Upping Door");
        }

        public void down()
        {
            print("Downing Door");
        }

        public void stop()
        {
            print("Stoped");
        }

        public void On()
        {
            Console.WriteLine("Light is On");
        }

        public void Off()
        {
            Console.WriteLine("Light is Off");
        }

        private void print(string String)
        {
            Console.WriteLine(String);
        }
    }



}


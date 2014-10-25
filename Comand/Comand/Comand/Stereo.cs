using System;
using System.CodeDom;

namespace Comand
{
    public class Stereo
    {

        public Stereo()
        {
        }

        public void on()
        {
            print("Stereo on");
        }

        public void off()
        {
            print("Stereo off"); 
        }

        public void SetCD()
        {
            print("CD has been set");
        }

        public void SetDVD()
        {
            print("DVD has been set");
        }

        public void SetRadio()
        {
            print("Radio has been changed");
        }

        public void SetVolume()
        {
            print("Volume changed"); 
        }

        private void print(string String)
        {
            Console.WriteLine(String);
        }
    }
}


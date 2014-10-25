using System;
using System.Net.Configuration;

namespace Comand
{
    public class CeilingFan
    {
        public  const int HIGH = 3;
        public  const int MEDIUM = 2;
        public  const int LOW = 1;
        public  const int OFF = 0;

        string Location;
        int speed;

        public CeilingFan(string location)
        {
            this.Location = location;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
        }

        public void medium()
        {
            speed = MEDIUM;
        }

        public void low()
        {
            speed = LOW;
        }

        public void off()
        {
            speed = OFF;
        }

        public int Speed
        {
            get
            {
                return speed;
            }
        }

         
    }
}


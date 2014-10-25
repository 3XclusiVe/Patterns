using System;
using System.IO.IsolatedStorage;
using System.Security;
using System.Dynamic;

namespace Singleton
{
    public class PCManager
    {
        private static PCManager info;


        private PCManager()
        {
            this.Name = "Apple";
            this.Model = "Macbook Air";
            this.Year = "Mid 2013";
        }

        public void Display()
        {
            Console.WriteLine(Name + Model + Year);
        }


        public static PCManager GetInfo
        {
            get
            {   
                if (info == null)
                {
                    info = new PCManager();
                }
                return info;
            }
        }



        public String Name;
        public String Model;
        public String Year;

    }
}


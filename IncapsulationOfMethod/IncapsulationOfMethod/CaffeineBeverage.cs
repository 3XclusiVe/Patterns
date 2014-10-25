using System;
using System.ComponentModel.Design.Serialization;

namespace IncapsulationOfMethod
{
    public abstract class  CaffeineBeverage : IprepareRecipee
    {
        public  void prepareRecipe()
        {
            boilWater();
            Brew();
            pourInCup();
            AddCondiments();
        }

        #region IprepareRecipee implementation

        public void boilWater()
        {
            print("Boiling Water"); 
        }

        public abstract void Brew();


        public   void pourInCup()
        {
            print("Pouring into cup");
        }

        public abstract void AddCondiments();


        #endregion

        private void print(string String)
        {
            Console.WriteLine(String);
        }
    }
}


using System;

namespace FabricaPattern
{
    /// <summary>
    /// Italiano pizza.
    /// </summary>
    public  class ItalianoPizza : Pizza
    {
        protected ItalianoPizza()
        {
            this.Base = "Slim";
            this.toppings.Add("Maccerele Cheese");
        }


        public virtual void prepare() {
            Console.WriteLine("Preparing " + this.Name);
        }
    }
    /// <summary>
    /// Cheese ttalio.
    /// </summary>
    public class CheeseTtalio : ItalianoPizza 
    {   
        PizzaIngridientFactory Factory;

        public CheeseTtalio(PizzaIngridientFactory Factory) {

            this.Name = "Cheese italio";
            this.toppings.Add("Tomato Souce");
            this.Souce = "without souce";

            this.Factory = Factory;

        }

        public override void prepare()
        {
            base.prepare();
            dough = Factory.createDough();
            Souce = Factory.createSauce();
            cheese = Factory.createCheese();
        }
    }

    public class Rome : ItalianoPizza {

        PizzaIngridientFactory Factory;

        public Rome(PizzaIngridientFactory Factory) {
            this.Base = "Fat";
            this.Name = "Rome";
            this.Souce = " Tomato ";
            this.Factory = Factory;
        }

        public override void prepare()
        {
            base.prepare();
            dough = Factory.createDough();
            Souce = Factory.createSauce();
            cheese = Factory.createCheese();
        }

    }
}


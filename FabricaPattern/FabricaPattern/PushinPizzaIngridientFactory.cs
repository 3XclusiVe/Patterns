using System;

namespace FabricaPattern
{
    public class PushinPizzaIngridientFactory : PizzaIngridientFactory
    {
        public PushinPizzaIngridientFactory()
        {
        }

        #region PizzaIngridientFactory implementation

        public Dough createDough()
        {
            return new ThinCrust();
        }

        public Sauce createSauce()
        {
            return new MarinaraSouce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Veggies[] createVeggies()
        {
           // Veggies veggies[] = {new Garlic(),new Onion(),new Mushroom(), new RedPepper()};
            //return veggies;
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        #endregion
    }
}


using System;

namespace FabricaPattern
{
    public class ItalioPizzaIngridientFactory : PizzaIngridientFactory
    {
        public ItalioPizzaIngridientFactory()
        {
        }

        #region PizzaIngridientFactory implementation

        public Dough createDough()
        {
            return new ThickCrust();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSouce();
        }

        public Cheese createCheese()
        {
            return new Mozzarella();
        }

        public Veggies[] createVeggies()
        {
            //Veggies veggies[] = {new Garlic(),new Onion(),new Mushroom(), new RedPepper()};
            //return veggies;
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClam()
        {
            return new FrozenClams();
        }

        #endregion
    }
}


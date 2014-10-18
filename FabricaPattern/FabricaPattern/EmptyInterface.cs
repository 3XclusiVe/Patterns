using System;

namespace FabricaPattern
{
    public interface  PizzaIngridientFactory
    {
     Dough createDough();
     Sauce createSauce();
     Cheese createCheese();
     Veggies[] createVeggies();
     Pepperoni createPepperoni();
     Clams createClam();
    }
}


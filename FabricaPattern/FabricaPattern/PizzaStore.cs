using System;

namespace FabricaPattern
{   
    /// <summary>
    /// СуперКлассФабрики
    /// </summary>
    public abstract class PizzaStore
    {
        public void orderPizza(String type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            Pizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            pizza.SendTo(" Jimm");

        }

        protected abstract Pizza createPizza(string type);
    }

    /// <summary>
    /// Pushin fab.
    /// </summary>
    public class PushinFab : PizzaStore
    {
        #region implemented abstract members of PizzaStore

        protected override Pizza createPizza(string type)
        {
            if (type == "Cheese")
            {
                return new CheesePusingPizza();
            }

            if (type == "Candy")
            {
                return new CandyPusingPizza();
            }
            else
            {
                return new CheesePusingPizza();
            }
        }

        #endregion
    }


    public class ItalianoFab : PizzaStore
    {
        #region implemented abstract members of PizzaStore

        protected override Pizza createPizza(string type)
        {   
            Pizza pizza = null;
            PizzaIngridientFactory Factory = new ItalioPizzaIngridientFactory();
            if (type == "Cheese")
            {
                return new CheeseTtalio(Factory);
            }

            if (type == "Candy")
            {
                return new Rome(Factory);
            }
            else
            {
                return new CheeseTtalio(Factory);
            }
        }

        #endregion


    }
}


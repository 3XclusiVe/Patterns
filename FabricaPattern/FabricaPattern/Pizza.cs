using System;
using System.Threading;
using System.Collections;

namespace FabricaPattern
{   /// <summary>
    /// АбстракныйСуперКлассПиццы
    /// </summary>
    public abstract class Pizza
    {
    
        protected string Name;
        protected string Base;
        protected string Souce;
        protected ArrayList toppings = new ArrayList();

        protected Dough dough;
        protected Sauce sauce;
        //protected Veggies veggies[];
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public Pizza()
        {
        }

        /**public void prepare() {
            Console.WriteLine("Preparing >> " + Name);
            Thread.Sleep(200);
            Console.WriteLine("Add Base >> " + Base);
            Thread.Sleep(200);
            Console.WriteLine("Add Souce >> " + Souce);
            Thread.Sleep(200);

            for (int i = 0; i < toppings.Count; i++) {
                Console.WriteLine("   " + toppings[i]);
            }

        }**/

        public abstract void prepare(); 

        /// <summary>
        /// Baking the Pizza
        /// </summary>
        public void bake() {
            Console.WriteLine("Bake for 25 minutes at 350");
            Thread.Sleep(2000);
        }
        /// <summary>
        /// Cutting Pizza
        /// </summary>
        public virtual void cut() {
            Console.WriteLine("Cutting pizza into diagonal slices");
            Thread.Sleep(1000);
        }
        /// <summary>
        /// Inboxing pizza
        /// </summary>
        public void  box() {
            Console.WriteLine("Inboxing");
            Thread.Sleep(500);
        }
        /// <summary>
        /// Sending pizza
        /// </summary>
        public void  SendTo( String Adress) {
            Console.WriteLine("Sended to the " + Adress);
        }

    }
        
}


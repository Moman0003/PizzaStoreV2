using System;
using UML_2_PizzaStoreV2;

namespace UML_2_PizzaStoreV2
{
    public class Store
    {
        private MenuCatalog _menuCatalog;

        public Store()
        {
            _menuCatalog = new MenuCatalog();
        }

        public void Test()
        {
            Pizza pizza1 = new Pizza() { Number = 1, Name = "Margherita", Price = 500 };
            _menuCatalog.CreatePizza(pizza1);

            Pizza pizza2 = new Pizza() { Number = 2, Name = "Pepperoni", Price = 60 };
            _menuCatalog.CreatePizza(pizza2);

            _menuCatalog.PrintMenu();

            Pizza foundPizza = _menuCatalog.FindPizza(1);
            if (foundPizza != null)
            {
                // Håndter tilfælde hvor en pizza blev fundet
                Console.WriteLine("Pizza found: " + foundPizza.Name);
            }
            else
            {
                // Håndter tilfælde hvor ingen pizza blev fundet
                Console.WriteLine("No pizza found.");
            }
        }
    }
}

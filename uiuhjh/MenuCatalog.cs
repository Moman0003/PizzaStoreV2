using System;
using System.Collections.Generic;

namespace UML_2_PizzaStoreV2
{
    public class MenuCatalog
    {
        private List<Pizza> _pizzas;

        public MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void CreatePizza(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu:");
            foreach (Pizza pizza in _pizzas)
            {
                Console.WriteLine(pizza);
            }
        }

        public Pizza FindPizza(int number)
        {
            return _pizzas.Find(pizza => pizza.Number == number) ?? new Pizza();
        }
    } 
}

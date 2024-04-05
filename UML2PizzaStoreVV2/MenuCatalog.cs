using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace UML_2_PizzaStoreV2
{
    public class Menucatalog
    {
        List<Pizza> _pizzas;

        public Menucatalog()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void Printmenu()
        {
            foreach (var p in _pizzas)
            {
                Console.WriteLine(p);
                Console.WriteLine("______________________________");
            }
        }
        public Pizza Read(int number)
        {
            return _pizzas[number - 1];
        }

        public Pizza? SearchPizza(string Criteria)
        {
            foreach (var p in _pizzas)
            {
                if (p.Name.ToLower() == Criteria.ToLower())
                    return p;
            }
            return null;

        }
        public void Update(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.Number == pizza.Number)
                {
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                    return;
                }
            }
        }
        public void Delete(Pizza pizza)
        {

            foreach (var p in _pizzas)
            {
                if (p.Number == pizza.Number)
                {
                    pizza = p;
                    break;
                }

            }
            _pizzas.Remove(pizza);
        }


    }

}
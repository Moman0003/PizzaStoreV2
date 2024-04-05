using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UML_2_PizzaStoreV2
{
    public class Store
    {
        Menucatalog menuCatalog;

        public Store()
        {
            menuCatalog = new Menucatalog();
            Test();
            Run();
        }

        public void Test()
        {
            Pizza p = new Pizza() { Number = 1, Name = "Margherita", Price = 69 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 2, Name = "Vesuvio", Price = 75 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 3, Name = "Capricciosa", Price = 80 };
            menuCatalog.Create(p);

            menuCatalog.Printmenu();


        }

        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
    }
}




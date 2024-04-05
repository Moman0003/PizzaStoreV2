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
            Pizza p = new Pizza() { Number = 1, Name = "Pizza#1", Price = 50 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 2, Name = "Pizza#2", Price = 55 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 3, Name = "Pizza#3", Price = 65 };
            menuCatalog.Create(p);

            menuCatalog.Printmenu();

            /// test

            ///test slut

        }

        public void Run()
        {
            new UserDialog(menuCatalog).Run();
        }
    }
}




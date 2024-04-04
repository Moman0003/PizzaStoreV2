using System;
using System.Collections.Generic;
using UML_2_PizzaStoreV2;

///Chick

namespace UML_2_PizzaStoreV2
{
    public class UserDialog
    {
        private MenuCatalog _menuCatalog;

        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Add new pizza");
                Console.WriteLine("2. Delete pizza");
                Console.WriteLine("3. Update pizza");
                Console.WriteLine("4. Search pizza");
                Console.WriteLine("5. Display pizza menu");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    switch (input)
                    {
                        case "1":
                            AddPizza();
                            break;
                        case "2":
                            DeletePizza();
                            break;
                        case "3":
                            UpdatePizza();
                            break;
                        case "4":
                            SearchPizza();
                            break;
                        case "5":
                            DisplayMenu();
                            break;
                        case "6":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }

        private void AddPizza()
        {
            // Logic for adding a new pizza
        }

        private void DeletePizza()
        {
            // Logic for deleting a pizza
        }

        private void UpdatePizza()
        {
            // Logic for updating a pizza
        }

        private void SearchPizza()
        {
            // Logic for searching for a pizza
        }

        private void DisplayMenu()
        {
            _menuCatalog.PrintMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_2_PizzaStoreV2;

namespace UML_2_PizzaStoreV2
{
    public class UserDialog
    {
        Menucatalog _menucatalog;

        public UserDialog(Menucatalog menucatalog)
        {
            _menucatalog = menucatalog;
        }

        void PrintPizza()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("|    Pizza menu   | ");
            Console.WriteLine("--------------------");
            _menucatalog.Printmenu();
        }

        Pizza DeletePizza()
        {
            Pizza pizzaitem2 = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("|   Delete pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            _menucatalog.Printmenu();
            Console.Write("enter pizza number: ");

            string? input = Console.ReadLine();

            if (input != null)
            {
                if (int.TryParse(input, out int number))
                {
                    pizzaitem2.Number = number;
                }
                else
                {
                    Console.WriteLine($"unable to parse {input}. Please enter a valid number.");
                    // Handle invalid input here, such as asking the user to input again or returning null
                }
            }
            else
            {
                Console.WriteLine("Input is null. Please provide a valid number.");
                // Handle null input here, such as asking the user to input again or returning null
            }

            return pizzaitem2;
        }


        Pizza Update()
        {
            Pizza pizzaitem1 = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Updating pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine("enter new pizza name: ");
            string? nameInput = Console.ReadLine(); // Tilføj ? for at tillade null
            if (nameInput != null)
            {
                pizzaitem1.Name = nameInput;
            }
            else
            {
                // Håndter null input efter behov
            }

            string? input = "";
            Console.Write("enter new price: ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem1.Price = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"unable to parse {input} - message: {e.Message}");
                    throw;
                }
            }
            else
            {
                // Håndter null input efter behov
            }

            input = "";
            Console.Write("enter new pizza number: ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem1.Number = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"unable to parse {input} - message: {e.Message}");
                    throw;
                }
            }
            else
            {
                // Håndter null input efter behov
            }
            return pizzaitem1;
        }




        Pizza Getnewpizza()
        {
            Pizza pizzaitem = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Creating pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.Write("enter pizza name: ");
            string? nameInput = Console.ReadLine(); // Tilføj ? for at tillade null
            if (nameInput != null)
            {
                pizzaitem.Name = nameInput;
            }
            else
            {
                // Håndter null input efter behov
            }

            string? input = "";
            Console.Write("enter price: ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem.Price = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"unable to parse {input} - message: {e.Message}");
                    throw;
                }
            }
            else
            {
                // Håndter null input efter behov
            }

            input = "";
            Console.Write("enter pizza number: ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem.Number = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"unable to parse {input} - message: {e.Message}");
                    throw;
                }
            }
            else
            {
                // Håndter null input efter behov
            }
            return pizzaitem;
        }


        int MainMenuChoice(List<string> menuitems)
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Haruns Pizzamenu |");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine("options:");
            foreach (string choice in menuitems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine($"unable to parse {input}");
            }
            return -1;
        }

        public void Run()
        {
            bool proceed = true;
            List<string> mainmenulist = new List<string>()
    {
        "0.quit",
        "1.Create new pizza",
        "2.print menu",
        "3.Update pizza",
        "4.Delete pizza"
    };

            while (proceed)
            {
                int menuchoice = MainMenuChoice(mainmenulist);
                Console.WriteLine();
                switch (menuchoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("quitting");
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = Getnewpizza();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Create(pizza);
                                Console.WriteLine($"you created: {pizza}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog is not initialized.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid data.");
                        }
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        PrintPizza();
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        try
                        {
                            Pizza pizza1 = Update();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Update(pizza1);
                                Console.WriteLine($"you have updated: {pizza1}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog is not initialized.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid data.");
                        }
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            Pizza pizza = DeletePizza();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Delete(pizza);
                                Console.WriteLine($"you have deleted: {pizza}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog is not initialized.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter valid data.");
                        }
                        Console.Write("hit any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}

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
            Console.WriteLine("|   Slet pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            _menucatalog.Printmenu();
            Console.Write("Skriv nummer på pizza ");

            string? input = Console.ReadLine();

            if (input != null)
            {
                if (int.TryParse(input, out int number))
                {
                    pizzaitem2.Number = number;
                }
                else
                {
                    Console.WriteLine($"Kan ikke analysere {input}. Venligst skriv et gyldigt nummer");
                    
                }
            }
            else
            {
                Console.WriteLine("Venligst skriv et gyldigt tal");
                
            }

            return pizzaitem2;
        }


        Pizza Update()
        {
            Pizza pizzaitem1 = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Opdater pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Skriv det nye navn til pizza:");
            string? nameInput = Console.ReadLine();
            if (nameInput != null)
            {
                pizzaitem1.Name = nameInput;
            }
            else
            {
              
            }

            string? input = "";
            Console.Write("Skriv den nye pris til pizza:");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem1.Price = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Kan ikke analysere {input} - besked: {e.Message}");
                    throw;
                }
            }
            else
            {
            
            }

            input = "";
            Console.Write("Skriv det nye nummer til pizza:");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem1.Number = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Kan ikke analysere {input} - besked: {e.Message}");
                    throw;
                }
            }
            else
            {
                
            }
            return pizzaitem1;
        }




        Pizza Getnewpizza()
        {
            Pizza pizzaitem = new Pizza();
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("| Opret ny pizza  | ");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.Write("Skriv navnet på pizza: ");
            string? nameInput = Console.ReadLine(); 
            if (nameInput != null)
            {
                pizzaitem.Name = nameInput;
            }
            else
            {
                
            }

            string? input = "";
            Console.Write("Skriv prisen: ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem.Price = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Kan ikke analysere {input} - besked: {e.Message}");
                    throw;
                }
            }
            else
            {
                
            }

            input = "";
            Console.Write("Skriv nummeret til pizza ");
            input = Console.ReadLine();
            if (input != null)
            {
                try
                {
                    pizzaitem.Number = Int32.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Kan ikke analysere {input} - besked: {e.Message}");
                    throw;
                }
            }
            else
            {
              
            }
            return pizzaitem;
        }


        int MainMenuChoice(List<string> menuitems)
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("| Big Mammas Pizzamenu |");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("Muligheder:");
            foreach (string choice in menuitems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Vælg en mulighed ved at skrive tallet: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Kan ikke analysere {input}");
            }
            return -1;
        }

        public void Run()
        {
            bool proceed = true;
            List<string> mainmenulist = new List<string>()
    {
        "0.Afslut",
        "1.Opret ny",
        "2.Se pizza menu",
        "3.Opdater pizza",
        "4.Slet pizza"
    };

            while (proceed)
            {
                int menuchoice = MainMenuChoice(mainmenulist);
                Console.WriteLine();
                switch (menuchoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("afslutter");
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = Getnewpizza();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Create(pizza);
                                Console.WriteLine($"Du har oprettet: {pizza}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog er ikke blevet startet.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ugyldig input. Indtast venligst gyldige data.");
                        }
                        Console.Write("Tryk på en knap for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 2:
                        PrintPizza();
                        Console.Write("Tryk på en knap for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 3:
                        try
                        {
                            Pizza pizza1 = Update();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Update(pizza1);
                                Console.WriteLine($"Du har opdateret: {pizza1}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog er ikke blevet startet.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ugyldig input. Indtast venligst gyldige data.");
                        }
                        Console.Write("Tryk på en knap for at fortsætte");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            Pizza pizza = DeletePizza();
                            if (_menucatalog != null)
                            {
                                _menucatalog.Delete(pizza);
                                Console.WriteLine($"Du har slettet: {pizza}");
                            }
                            else
                            {
                                Console.WriteLine("MenuCatalog er ikke blevet startet.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ugyldig input. Indtast venligst gyldige data.");
                        }
                        Console.Write("Tryk på en knap for at fortsætte");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Ugyldigt valg. Prøv venligst igen.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}

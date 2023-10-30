using System.Reflection.PortableExecutable;

namespace _2310857_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vender machine = new Vender();

            int choice = 0;
            while (choice != 3) // main loop
            {
                Console.WriteLine($"{(machine.MilkStock <= 0 ? "NO MILK" : "")} {(machine.SugarStock <= 0 ? "NO SUGAR" : "")}");
                Console.WriteLine("----| Drink Dispenser |----");
                Console.WriteLine($"1) dispense tea {(machine.TeaStock <= 0 ? "(OUT OF STOCK)" : "")}");
                Console.WriteLine($"2) dispense coffee {(machine.CoffeeStock <= 0 ? "(OUT OF STOCK)" : "")}");
                Console.Write("Select Option:\n>>> ");
                string input = Console.ReadLine();
                try
                {
                    choice = Convert.ToInt32(input); // attept to convert choice
                }
                catch
                {
                    // if not valid number output error
                    Console.WriteLine("Invalid Input!\n");
                }

                switch (choice) // handle drinks dispensing
                {
                    case 1:
                        if (machine.TeaStock <= 0)
                        {
                            Console.WriteLine("OUT OF STOCK");
                            break;
                        }
                        else
                        {
                            List<bool> milksugar = getPrefs();
                            bool success = machine.dispenseTea(milksugar[0], milksugar[1]);
                            Console.WriteLine($"Drink was {(success ? "dispensed." : "not dispensed due to missing stock")}\n");

                        }
                        break;

                    case 2:
                        if (machine.CoffeeStock <= 0)
                        {
                            Console.WriteLine("OUT OF STOCK");
                            break;
                        }
                        else
                        {
                            List<bool> milksugar = getPrefs();
                            bool success = machine.dispenseCoffee(milksugar[0], milksugar[1]);
                            Console.WriteLine($"Drink was {(success ? "dispensed." : "not dispensed due to missing stock") }\n");

                        }
                        break;
                }
            }

        }
        static List<bool> getPrefs() // get users sugar and mik preferences
        {
            List<bool> prefs = new List<bool> { false, false }; // default preferences

            Console.Write("Milk? (Y/N):\n>>> "); // ask if they want milk
            char yn = 'u';
            while (yn == 'u')
            {
                ConsoleKeyInfo key = Console.ReadKey(true); // wait for Y/N keypress

                switch (Char.ToLower(key.KeyChar))
                {
                    case 'y':
                        prefs[0] = true;
                        yn = 'y';
                        break;

                    case 'n':
                        yn = 'n';
                        break;
                }
            }
            Console.Write($"{yn}\n\n");


            Console.Write("Sugar? (Y/N):\n>>> "); // ask if they want sugar
            yn = 'u';
            while (yn == 'u')
            {
                ConsoleKeyInfo key = Console.ReadKey(true); // wait for Y/N keypress

                switch (Char.ToLower(key.KeyChar))
                {
                    case 'y':
                        prefs[1] = true;
                        yn = 'y';
                        break;

                    case 'n':
                        yn = 'n';
                        break;
                }
            }
            Console.Write($"{yn}\n");

            return prefs; // return prefs
        }

    }
}
namespace MainProgram;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose task:\n");
            Console.WriteLine("1. Proxy (Youtube get video)");
            Console.WriteLine("2. Decorator (Coffee shop)");
            Console.WriteLine("3. Adapter (Logger)");
            Console.WriteLine("0. Exit");
            string? input = InputHelpers.StringInput("\nYour choice: ");

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 0)
                {
                    Console.WriteLine("\nExitting...");
                    return;
                }
                else if (userChoice == 1)
                {
                    Proxy.Menu.Run();
                }
                else if (userChoice == 2)
                {
                    Decorator.Menu.Run();
                }
                else if (userChoice == 3)
                {
                    Logger.Menu.Run();
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a digit between 0-4!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a digit!");
            }
        }
    }
}
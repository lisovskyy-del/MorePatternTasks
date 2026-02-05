namespace MainProgram.Decorator;

class Menu
{
    public static void Run()
    {
        Beverage beverage = new Espresso();
        beverage = new Milk(beverage);
        beverage = new Sugar(beverage);

        Console.WriteLine($"Beverage: {beverage.Description}");
        Console.WriteLine($"Cost: {beverage.Cost()}");
    }
}

namespace MainProgram.Logger;

class Menu
{
    public static void Run()
    {
        ILogger logger = new FileLoggerAdapter(new FileWriter());

        logger.Log("User entered system");
        logger.Error("Lost connection with database");
    }
}

namespace MainProgram.Decorator;

public abstract class Beverage
{
    public virtual string Description { get; protected set; } = "Unknown Beverage";

    public abstract double Cost();
}

public class Espresso : Beverage
{
    public override string Description => "Espresso";

    public override double Cost()
    {
        return 60.0;
    }
}

public class Tea : Beverage
{
    public override string Description => "Tea";

    public override double Cost()
    {
        return 40.0;
    }
}
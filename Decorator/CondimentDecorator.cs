namespace MainProgram.Decorator;

public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected Beverage _beverage = beverage;

    public override abstract string Description { get; }
}


public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }

    public override string Description => _beverage.Description + ", with milk";


    public override double Cost()
    {
        return _beverage.Cost() + 15.0;
    }
}

public class Sugar : CondimentDecorator
{
    public override string Description => _beverage.Description + ", with sugar";

    public Sugar(Beverage beverage) : base(beverage)
    {
    }

    public override double Cost()
    {
        return _beverage.Cost() + 5.0;
    }
}

public class Chocolate : CondimentDecorator
{
    public override string Description => _beverage + ", with chocolate";

    public Chocolate(Beverage beverage) : base(beverage)
    {
    }

    public override double Cost()
    {
        return _beverage.Cost() + 20.0;
    }
}
using Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

namespace Chapter12.DuckReunion.CompoundPattern.Ducks;

public abstract class AbstractDuckFactory
{
    public abstract IQuackable CreateMallardDuck();

    public abstract IQuackable CreateRedHeadDuck();

    public abstract IQuackable CreateDuckCall();

    public abstract IQuackable CreateRubberDuck();
}

public class DuckFactory: AbstractDuckFactory
{
    public override IQuackable CreateMallardDuck()
    {
        return new MallardDuck();
    }

    public override IQuackable CreateRedHeadDuck()
    {
        return new RedheadDuck();
    }

    public override IQuackable CreateDuckCall()
    {
        return new DuckCall();
    }

    public override IQuackable CreateRubberDuck()
    {
        return new RubberDuck();
    }
}
using Chapter12.DuckReunion.CompoundPattern.Ducks;

namespace Chapter12.DuckReunion.CompoundPattern.QuackBehaviours;

public class CountingDuckFactory: AbstractDuckFactory
{
    #region Public Methods

    public override IQuackable CreateDuckCall()
    {
        return new QuackCounter(new DuckCall());
    }

    public override IQuackable CreateMallardDuck()
    {
        return new QuackCounter(new MallardDuck());
    }

    public override IQuackable CreateRedHeadDuck()
    {
        return new QuackCounter(new RedheadDuck());
    }

    public override IQuackable CreateRubberDuck()
    {
        return new QuackCounter(new RubberDuck());
    }

    #endregion
}

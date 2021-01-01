namespace StrategyPattern.DecoratorPattern
{
    public class CheeseTopping:Topping
    {
        private readonly IPizza _pizza;
        public CheeseTopping(IPizza pizza)
        {
            _pizza = pizza;
            _description = _pizza.getDescription() + " With Cheese";
        }
        public override double Cost()
        {
            return _pizza.Cost() + 0.99;
        }

        public override string GetDescription()
        {
            return _pizza.getDescription()+" With Cheese";
        }
    }
}
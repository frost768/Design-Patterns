namespace StrategyPattern.DecoratorPattern
{
    public class ThinCrustPizza:IPizza
    {
        public ThinCrustPizza()
        {
            _description = "Thin Crust Pizza";
        }
        public override double Cost()
        {
            return 10.99;
        }
    }
}
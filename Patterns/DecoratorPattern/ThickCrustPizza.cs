namespace StrategyPattern.DecoratorPattern
{
    public class ThickCrustPizza:IPizza
    {
        public ThickCrustPizza()
        {
            _description = "Thick Crust Pizza";
        }


        public override double Cost()
        {
            return 12.99;
        }
    }
}
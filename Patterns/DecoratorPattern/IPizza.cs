namespace StrategyPattern.DecoratorPattern
{
    public abstract class IPizza
    {
        protected string _description;

        public string getDescription()
        {
            return _description;
        }
        public abstract double Cost();

    }
}
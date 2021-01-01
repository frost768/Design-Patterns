using System;

namespace StrategyPattern.DecoratorPattern
{
    public abstract class Topping:IPizza
    {
        public abstract String GetDescription();
    }
}
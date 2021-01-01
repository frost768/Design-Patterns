using System;

namespace StrategyPattern.IteratorPattern
{
    public class Cafe
    {
        private IAggregate _pancakeMenu;
        private IAggregate _dinerMenu;

        public Cafe(IAggregate pancakeMenu,IAggregate dinerMenu)
        {
            _pancakeMenu = pancakeMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu(IIterator<string> iterator)
        {
            while (iterator.HasNext())
            {
                string menuItem = iterator.Next();
                Console.WriteLine(menuItem);
            }
        }
    }
}
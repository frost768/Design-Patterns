using System.Collections.Generic;

namespace StrategyPattern.IteratorPattern
{
    public class PancakeMenuIterator:IIterator<string>
    {
        private List<string> list;
        private int pos = 0;
        public PancakeMenuIterator()
        {
            this.list = list;
        }
        public bool HasNext()
        {
            return list.Capacity - pos == 0;
        }

        public string Next()
        {
            return list[pos++];
        }
    }
}
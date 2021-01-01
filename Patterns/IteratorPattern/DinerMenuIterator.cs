namespace StrategyPattern.IteratorPattern
{
    public class DinerMenuIterator:IIterator<string>
    {
        private string[] list;
        private int pos = 0;
        public DinerMenuIterator()
        {
            this.list = list;
        }
        public bool HasNext()
        {
            return list.Length - pos == 0;
        }

        public string Next()
        {
            return list[pos++];
        }
    }
}
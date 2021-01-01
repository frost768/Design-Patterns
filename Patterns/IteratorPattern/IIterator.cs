namespace StrategyPattern.IteratorPattern
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public T Next();
    }
}
using System;

namespace StrategyPattern.AdapterPattern
{
    public abstract class Duck:IDuck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }
        
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }

        public void TestDuck()
        {
            Quack();
            Fly();
            
        }
        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void Quack()
        {
            QuackBehaviour.Quack();
        }
        public abstract void Display();

    }
   
    public interface IDuck
    {
        public void Fly();
        public void Quack();
        
        
    }
    public class SqueakBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak squeak!!");
        }
    }
    public class QuackBehaviour:IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack!!");
        }
    }

    public interface IQuackBehaviour
    {
        public void Quack();
    }

    public class FlyNoWay:IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
    public class FlyWithWings:IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
    public interface IFlyBehaviour
    {
        public void Fly();
    }

    public class MallardDuck:Duck
    {
        
        public override void Display()
        {
            Console.WriteLine("I am mallard duck");
        }
    }
}
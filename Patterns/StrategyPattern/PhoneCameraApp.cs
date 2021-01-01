using System;

namespace StrategyPattern
{
    public abstract class PhoneCameraApp
    {
        private IShareBehaviour _behaviour;
        public IShareBehaviour shareBehaviour
        {
            get => _behaviour;
            set => _behaviour = value;
        }
        
        public void Take()
        {
            Console.WriteLine("Photo has taken");
        }

        public void Save()
        {
            Console.WriteLine("Photo has been saved");
        }

        public void Share()
        {
            shareBehaviour.Share();
        }

        public abstract void Edit();
        
    }

    public class ShareOnSocialMedia : IShareBehaviour
    {
        public void Share()
        {
            Console.WriteLine("Shared on social media");
        }
    }
    public class ShareByText : IShareBehaviour
    {
        public void Share()
        {
            Console.WriteLine("Shared by text");
        }
    }
    public class ShareByEmail : IShareBehaviour
    {
        public void Share()
        {
            Console.WriteLine("Shared by email");
        }
    }

    public interface IShareBehaviour
    {
        void Share();
    }
    
}
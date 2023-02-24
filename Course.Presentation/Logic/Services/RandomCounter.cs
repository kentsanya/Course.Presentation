using Course.Presentation.Logic.Interfaces;

namespace Course.Presentation.Logic.Services
{
    public class RandomCounter:ICounter
    {
        static Random random= new Random();
        private int _value;
        public RandomCounter() 
        {
            _value = random.Next(1,1000);
        }
        public int Value { get { return _value; } }
     }
}

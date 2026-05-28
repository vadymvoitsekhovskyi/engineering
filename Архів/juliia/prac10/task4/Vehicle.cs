namespace task4
{
    public abstract class Vehicle
    {
        private int _speed;

        public int Speed
        {
            get { 
                return _speed; 
            }
        }

        protected void SetSpeed(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Помилка! Швидкість не може бути від'ємною.");
                _speed = 0;
            }
            else
            {
                _speed = value;
            }
        }

        public abstract void Start();
        public abstract void Stop();
    }
}
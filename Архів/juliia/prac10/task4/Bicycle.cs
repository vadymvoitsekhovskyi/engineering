namespace task4
{
    public class Bicycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Велосипед починає їхати.");
            SetSpeed(10);
        }

        public override void Stop()
        {
            Console.WriteLine("Велосипед спиняється.");
            SetSpeed(0);
        }
    }
}
namespace task4
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Автомобіль починає рух.");
            SetSpeed(50);
        }

        public override void Stop()
        {
            Console.WriteLine("Автомобіль зупиняється.");
            SetSpeed(0);
        }
    }
}
namespace task3
{
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Автомобіль: повертаємо ключ, запускається стартер, потім двигун і автомобіль починає рух.");
        }

        public override void Stop()
        {
            Console.WriteLine("Автомобіль: тиснемо педаль гальма, зупиняємось, повертаємо ключ назад.");
        }
    }
}
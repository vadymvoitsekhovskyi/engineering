namespace task3
{
    public class Bicycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Велосипед: починаємо крутити педалі і велосипед іде.");
        }

        public override void Stop()
        {
            Console.WriteLine("Велосипед: тиснемо ручні гальма і велосипед спиняється.");
        }
    }
}
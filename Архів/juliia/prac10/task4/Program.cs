using System.Text;

namespace task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Vehicle myCar = new Car();
            Vehicle myBike = new Bicycle();

            myCar.Start();
            Console.WriteLine($"Швидкість авто: {myCar.Speed} км/год.");
            myCar.Stop();
            Console.WriteLine($"Швидкість авто: {myCar.Speed} км/год.");

            Console.WriteLine();

            myBike.Start();
            Console.WriteLine($"Швидкість велосипеда: {myBike.Speed} км/год.");
            myBike.Stop();
            Console.WriteLine($"Швидкість авто: {myBike.Speed} км/год.");
        }
    }
}
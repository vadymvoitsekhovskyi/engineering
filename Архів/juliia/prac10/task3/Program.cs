using System.Text;

namespace task3
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
            myCar.Stop();

            myBike.Start();
            myBike.Stop();
        }
    }
}
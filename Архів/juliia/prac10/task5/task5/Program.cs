using System.Text;

namespace task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ICalculator calculator = new Calculator();

            Console.Write("Введіть перше число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть оператор: ");
            string operation = Console.ReadLine();

            Console.Write("Введіть друге число: ");
            double b = double.Parse(Console.ReadLine());

            double result;

            switch (operation)
            {
                case "+":
                    result = calculator.Add(a, b); 
                    break;
                case "-":
                    result = calculator.Subtract(a, b); 
                    break;
                case "*":
                    result = calculator.Multiply(a, b); 
                    break;
                case "/":
                    result = calculator.Divide(a, b);
                    break;
                default:
                    Console.WriteLine("Введено невірне значення.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
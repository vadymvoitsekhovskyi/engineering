namespace builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ISandwichBuilder veggieBuilder = new VeggieSandwichBuilder();
            Director director = new Director(veggieBuilder);
            director.BuildSandwich();
            ISandwich veggie = veggieBuilder.GetSandwich();

            Console.WriteLine("Вегетаріанський сендвіч");
            Console.WriteLine($"Інгредієнти: {veggie}");
            Console.WriteLine();

            ISandwichBuilder meatBuilder = new MeatLoversBuilder();
            director = new Director(meatBuilder);
            director.BuildSandwich();
            ISandwich meat = meatBuilder.GetSandwich();

            Console.WriteLine("М'ясний сендвіч");
            Console.WriteLine($"Інгредієнти: {meat}");
        }
    }
}
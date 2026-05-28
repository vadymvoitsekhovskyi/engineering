namespace iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            RestaurantMenu menu = new RestaurantMenu();
            menu.AddItem("Борщ український", 120.00);
            menu.AddItem("Вареники з картоплею", 95.50);
            menu.AddItem("Котлета по-київськи", 150.00);
            menu.AddItem("Узвар", 40.00);
            
            IIterator iterator = menu.CreateIterator();
            Console.WriteLine("\nМеню Ресторану");
            
            while (iterator.HasNext())
            {
                MenuItem item = iterator.Next();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
namespace visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Library library = new Library();
            library.AddItem(new Book("Тіні забутих предків", "Михайло Коцюбинський", 3));
            library.AddItem(new Book("Кобзар", "Тарас Шевченко", 0));
            library.AddItem(new Magazine("Наука і суспільство", 12, 5));
            library.AddItem(new Magazine("National Geographic", 4, 1));
            
            Console.WriteLine("Генерація звіту по матеріалах бібліотеки");
            ReportVisitor reportVisitor = new ReportVisitor();
            library.AcceptVisitor(reportVisitor);
            
            Console.WriteLine("\nРозрахунок штрафів за протермінування");
            LateFeeVisitor lateFeeVisitor = new LateFeeVisitor();
            library.AcceptVisitor(lateFeeVisitor);

            Console.WriteLine($"\nЗагальна сума штрафів для бібліотеки: {lateFeeVisitor.TotalPenalty} грн.");
        }
    }
}
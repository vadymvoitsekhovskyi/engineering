namespace chain_of_responsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Approver manager = new Manager();
            Approver director = new Director();
            Approver ceo = new CEO();
            
            manager.SetNext(director);
            director.SetNext(ceo);
            
            PurchaseRequest request1 = new PurchaseRequest("Офісний папір та ручки", 150);
            PurchaseRequest request2 = new PurchaseRequest("Нові ноутбуки для відділу", 3500);
            PurchaseRequest request3 = new PurchaseRequest("Купівля службового авто", 25000);
            
            Console.WriteLine("Обробка запитів");
            manager.ProcessRequest(request1);
            manager.ProcessRequest(request2);
            manager.ProcessRequest(request3);
        }
    }
}
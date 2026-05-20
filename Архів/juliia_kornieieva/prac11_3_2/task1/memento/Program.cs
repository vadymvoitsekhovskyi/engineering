namespace memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Warehouse myWarehouse = new Warehouse(100);
            WarehouseHistory history = new WarehouseHistory(myWarehouse);
            
            history.Backup();             
            myWarehouse.SellProducts(20); 

            history.Backup();            
            myWarehouse.AddProducts(50); 

            history.Backup();            
            myWarehouse.SellProducts(120);
            
            // all created backups
            history.ShowHistory();
            
            history.Undo(); 
            history.Undo();
        }
    }
}
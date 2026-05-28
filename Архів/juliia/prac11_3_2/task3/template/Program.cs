namespace template
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LibraryItemReturnProcess bookProcessor = new PaperBookReturn();
            bookProcessor.ProcessReturn("Кобзар (Т. Г. Шевченко)");
            
            LibraryItemReturnProcess discProcessor = new MultimediaDiscReturn();
            discProcessor.ProcessReturn("Англійська для початківців (Аудіо CD)");
        }
    }
}
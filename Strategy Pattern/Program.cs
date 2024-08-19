namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order(1, 5, "Mobile", " Ahmed", "Samsung");
            order.Export(new CSVExportService());

            order.Export(new PDFExportService());

            order.Export(new XMLExportService());

            Console.ReadKey();
        }
    }
}

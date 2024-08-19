namespace Facade_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var facade = new DiscountFacade();

            Console.WriteLine($"Discount = {facade.CalculateOrderDiscountPrecentage(10)}");
            Console.ReadKey();
        }
    }
}

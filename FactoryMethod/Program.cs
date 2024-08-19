namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var CodediscountFactory = new CodeDiscountFactory(Guid.NewGuid());
            //var CountrydiscountFactory = new CountryDiscountFactory("BE");

            //var codediscountservice = CodediscountFactory.CreateDiscountService();
            //var countrydiscountservice = CountrydiscountFactory.CreateDiscountService();
            //Console.WriteLine($"Precentage is {codediscountservice.DiscountPrecentage} and Coming from {codediscountservice}");
            //Console.WriteLine($"Precentage is {countrydiscountservice.DiscountPrecentage} and Coming from {countrydiscountservice}");
            //Console.ReadLine();
            bool isMale = true;
            var factories = new List<DiscountFactory>() {
                new  CodeDiscountFactory(Guid.NewGuid()) ,
                new CountryDiscountFactory("EGY"),
                new GenderDiscountFactory(isMale)
            };
            foreach (var factory in factories)
            {
                var disocuntService = factory.CreateDiscountService();
                Console.WriteLine($"Precentage is {disocuntService.DiscountPrecentage} and Coming from {disocuntService}");
            }

            Console.ReadLine();
        }
    }
}

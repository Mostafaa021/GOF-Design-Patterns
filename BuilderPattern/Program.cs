namespace BuilderPattern;

 public class  Program
{
    static void Main(string[] args) 
    {
        
        Console.WriteLine("Car Builder!");
         // Original Implementation of Builder
         var garage = new BuilderPattern.CarDirector();
         var SportsCar = new BuilderPattern.SedanCar("SportsCar");
         garage.Build(SportsCar);
         Console.WriteLine(SportsCar.GetCar().ToString());
        
        // Another Variation of Builder Pattern (Fluent Builder)
         var fluentCar =new AnotherImplmentUseCase.CarBuilderFluent("SportsCar");
         fluentCar.BuildWheels().BuildDoors().BuildEngine().Build();
        
        
    }
    
}
using System.Text;

namespace BuilderPattern;

public class AnotherImplmentUseCase
{
    
    public interface ICarBuilderFluent
    {
        ICarBuilderFluent BuildEngine();
        ICarBuilderFluent BuildWheels();
        ICarBuilderFluent BuildDoors();
        ICarBuilderFluent BuildSeats();
        BuilderPattern.Car Build();
    }

    
    public class CarBuilderFluent : ICarBuilderFluent
    {
        public string _carModel { get; set; }
        private readonly BuilderPattern.Car _car; // should keep track of the car being built

        public CarBuilderFluent(string carModel)
        {
            _carModel = carModel;
            _car = new BuilderPattern.Car(carModel);
        }

        public ICarBuilderFluent BuildWheels()
        {
            Console.WriteLine("Build Wheels Builder");
            return this;
        }

        public ICarBuilderFluent BuildEngine()
        {
            Console.WriteLine("Build Engine Builder");
            return this;
        }

        public ICarBuilderFluent BuildDoors()
        {
            Console.WriteLine("Build Doors Builder");
            return this;
        }

        public ICarBuilderFluent BuildSeats()
        {
            Console.WriteLine("Build Seats Builder");
            return this;
        }
        public BuilderPattern.Car Build( )
        {
            Console.WriteLine("Build Car  of Model: " + _carModel);
            return _car;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Car Builder here is new Implementation");
            return sb.ToString();
        }
    }
    
}
using System.Text;

namespace BuilderPattern;

public class BuilderPattern
{
    // Product to be built by the builder
    public class Car
    {
        private readonly string _carModel;
        private readonly List<string> _parts = new();

        public Car( string carModel )
        {
            _carModel = carModel;
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in _parts)
            {
                sb.AppendLine($" car of Model {_carModel} has part {part}");
            }
            return sb.ToString();  
        }
        public void Show()
        {
            Console.WriteLine("Car Model: " + _carModel);
        }
    }
    
    // Builder interface 
    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildDoors();
        void BuildSeats();
        Car GetCar();
    }
    // Concrete Builder  for Sedan Car
    public class SedanCar : ICarBuilder
    {
        private readonly Car _car; // should keep track of the car being built
        public SedanCar(string carModel)
        {
            _car = new Car(carModel);
        }
        public void BuildEngine()
        {
            _car.AddPart("Sedan Engine");
        }

        public void BuildWheels()
        {
            _car.AddPart("Sedan Wheels");
        }

        public void BuildDoors()
        {
            _car.AddPart("Sedan Doors");
        }

        public void BuildSeats()
        {
            _car.AddPart("Sedan Seats");
        }

        public Car GetCar()
        {
            return _car;
        }
    }
     // Concrete Builder for Sports Car
     public class SportsCar : ICarBuilder
     {
         private readonly Car _car;// should keep track of the car being built
         public SportsCar( string model)
         {
           _car = new Car(model);  
         }
         public void BuildEngine()
         {
             _car.AddPart("Sports Engine");
         }

         public void BuildWheels()
         {
             _car.AddPart("Sports Wheels");
         }

         public void BuildDoors()
         {
             _car.AddPart("Sports Doors");
         }

         public void BuildSeats()
         {
             _car.AddPart("Sports Seats");
         }

         public Car GetCar()
         {
             return _car;
         }
     }
     //Director 
     public class CarDirector
     {
         private ICarBuilder? _builder; // should keep track of the (Concrete Builder)  being used
         
         public void Build(ICarBuilder builder)
         {
             _builder = builder;
             _builder.BuildEngine();
             _builder.BuildWheels();
             _builder.BuildDoors();
             _builder.BuildSeats();
         }
     }
    
}
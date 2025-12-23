// Polymorphism         = Greek word that means to have "Many Forms".
//                        Treating different objects as their common base type
//                        Objects can be identified by more than one type
//                        Ex. A Dog is also: Canine, Animal, Organism
//                        Allows a List<Animal> to hold Dogs, Cats, and Birds
//                        Code is written for the Parent, but executes Child behavior

namespace P05_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            // Car[] vehicles = { car, bicycle, boat }; // Error: cannot convert from 'Bicycle' to 'Car'
            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }
    abstract class Vehicle
    {
        public virtual void Go()
        {

        }
    }
    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}

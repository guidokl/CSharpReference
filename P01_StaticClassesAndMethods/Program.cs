// Static Class/Method  = Belongs to the type itself, not a specific object
//                        Cannot create an instance using 'new'
//                        Global utility (e.g., Console.WriteLine, Math.Round)

namespace P01_StaticClassesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("This is a static method in the Program class.");

            Car car1 = new Car();
            car1.StartEngine();
            Tools.PrintMessage($"This car has {car1.NumberOfWheels} wheels.");
            // Car.StartEngine(); // This line would cause a compile-time error because StartEngine is not static

            Tools.PrintMessage("Hello."); // Possible to call static method directly
            // Tools tool1 = new Tools(); // This line would cause a compile-time error
            // because static classes cannot be instantiated
        }
        static void Write(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Car
    {
        public int NumberOfWheels = 4;
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
    }

    static class Tools
    {
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

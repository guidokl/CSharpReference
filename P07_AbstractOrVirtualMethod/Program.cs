// Abstract or Virtual Method, Which Fits Better Here? (by Zoran Horvat)
// https://www.youtube.com/watch?v=Tu3FEWTmaQY

// Virtual vs Abstract  = Defining how child classes handle methods
//                        Virtual  = Has default logic, child CAN override it
//                        Abstract = No default logic, child MUST override it

Vehicle vehicle1 = new Vehicle("Toyota", "Buggy");
Car car1 = new Car("Honda", "Civic");

Console.WriteLine("> Vehicle vehicle1");
Console.WriteLine($"{vehicle1.Brand} {vehicle1.Model} - Engine Status: {vehicle1.EngineStatus}");
vehicle1.StartEngine();
Console.WriteLine($"{vehicle1.Brand} {vehicle1.Model} - Engine Status: {vehicle1.EngineStatus}");

Console.WriteLine("> Car car1");
Console.WriteLine($"{car1.Brand} {car1.Model} - Engine Status: {car1.EngineStatus}, Screen Content: {car1.ScreenContent}");
car1.StartEngine();
Console.WriteLine($"{car1.Brand} {car1.Model} - Engine Status: {car1.EngineStatus}, Screen Content: {car1.ScreenContent}");

// Different Approach
class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string EngineStatus { get; private set; } = "Off";

    public Vehicle(string brand, string model) =>
        (Brand, Model) = (brand, model);

    public void StartEngine()
    {
        if (EngineStatus != "Off") return;
        BeforeEngineStart();
        EngineStatus = "Idle";
        AfterEngineStart();
    }

    // Protected abstract methods to be implemented by derived classes,
    // not public because they are internal steps of the engine starting process
    //protected abstract void BeforeEngineStart();
    //protected abstract void AfterEngineStart();
    // Can also be protected virtual methods with default implementations
    protected virtual void BeforeEngineStart() { }
    protected virtual void AfterEngineStart() { }
}

class Car : Vehicle
{
    public string ScreenContent { get; private set; } = "Off";

    public Car(string brand, string model) : base(brand, model) { }

    // Implement the abstract methods or override the virtual methods
    //protected override void BeforeEngineStart() { }

    protected override void AfterEngineStart()
    {
        ScreenContent = "BasicInfo";
    }
}

// Base Design
//class Vehicle
//{
//    public string Brand {  get; set; }
//    public string Model { get; set; }
//    public string EngineStatus { get; private set; } = "Off";

//    public Vehicle(string brand, string model) =>
//        (Brand, Model) = (brand, model);

//    public virtual void StartEngine()
//    {
//        EngineStatus = "Idle";
//    }
//}

//class Car : Vehicle
//{
//    public string ScreenContent { get; private set; } = "Off";

//    public Car(string brand, string model) : base(brand, model) { }

//    public override void StartEngine()
//    {
//        base.StartEngine(); // Call the base class method to set EngineStatus to "Idle", but what comes first?
//        ScreenContent = "BasicInfo";
//    }
//}
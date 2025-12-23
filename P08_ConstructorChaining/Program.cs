// Constructor Chaining = Linking constructors to avoid duplicate initialization code
//                        : base(...) passes control upward (parent class) for inheritance
//                        : this(...) passes control sideways (same class) for defaults

Console.WriteLine("Nothing to run here!");

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    // Constructor
    public Person(string name, int age) =>
        (Name, Age) = (name, age);
}

class Employee : Person
{
    public int EmployeeID { get; set; }
    // Constructor
    public Employee(string name, int age, int employeeID)
        : base(name, age) // Call base class constructor and pass parameters
    {
        EmployeeID = employeeID;
    }
}
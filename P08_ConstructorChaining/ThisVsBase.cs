class Machine
{
    public int Id { get; set; }

    // 3. Finally, the Base constructor runs
    public Machine(int id)
    {
        Id = id;
        Console.WriteLine($"[Machine] ID {id} set.");
    }
}

class Robot : Machine
{
    public string Name { get; set; }

    // 1. Entry Point: User calls this with just an ID
    //    It chains to the MAIN constructor below using 'this'
    public Robot(int id)
        : this(id, "Unknown Droid")
    {
        Console.WriteLine("[Robot] Default name applied.");
    }

    // 2. Main Constructor: Receives ID and Name
    //    It chains UP to the parent using 'base'
    public Robot(int id, string name)
        : base(id)
    {
        Name = name;
        Console.WriteLine($"[Robot] Name {name} set.");
    }
}
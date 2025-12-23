// Inheritance          = Creating a new class based on an existing one
//                        Parent (Base) -> Child (Derived)
//                        Child automatically gets all public/protected members of Parent

namespace P04_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drone drone1 = new Drone();
            HealingDrone drone2 = new HealingDrone();

            drone1.Move();
            drone1.UseSkill();

            drone2.Move();
            drone2.UseSkill();

            Console.WriteLine("--------------");

            List<Drone> squad = new List<Drone> { drone1, drone2 };
            foreach (Drone drone in squad)
            {
                drone.Move();
                drone.UseSkill();
            }
        }
    }

    class Drone
    {
        public void Move()
        {
            Console.WriteLine("The drone is moving.");
        }
        public virtual void UseSkill()
        {
            Console.WriteLine("The drone is attacking.");
        }
    }

    class HealingDrone : Drone
    {
        public override void UseSkill()
        {
            Console.WriteLine("The drone is healing.");
        }
    }
}

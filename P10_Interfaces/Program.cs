using System;
using System.Collections.Generic;

namespace P10_Interfaces
{
    // Interfaces           = A contract that defines a set of behaviors (Methods/Properties)
    //                        Defines WHAT a class must do, but not HOW to do it
    //                        Classes can implement multiple interfaces (unlike class inheritance)
    //                        Interfaces are reference types
    //                        Interfaces can contain methods, properties, events, and indexers
    //                        Interfaces cannot contain fields or implementation details

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEnemy> enemies = new List<IEnemy>();

            // 1. Add standard monsters
            enemies.Add(new Dragon());
            enemies.Add(new Vampire());

            // 2. THE POWER OF INTERFACES:
            // We can add an 'ExplodingBarrel' to this list even though it is NOT a creature.
            // It inherits from 'Prop', not 'Monster', yet it fits in the list because it signed the contract.
            enemies.Add(new ExplodingBarrel());

            // Polymorphism: The loop doesn't care if it's a Prop or a Creature.
            // It only knows they all implement Attack() and Defend().
            foreach (IEnemy enemy in enemies)
            {
                Console.WriteLine("--- New Target ---");
                enemy.Attack();
                enemy.Defend();
            }

            Console.ReadKey();
        }
    }

    // The Contract
    public interface IEnemy
    {
        void Attack();
        void Defend();
    }

    // --- FAMILY TREE A: LIVING CREATURES ---
    // These could technically inherit from a base class "Monster"
    public class Dragon : IEnemy
    {
        public void Attack() => Console.WriteLine("The dragon breathes fire!");
        public void Defend() => Console.WriteLine("The dragon spreads its wings to shield itself!");
    }

    public class Vampire : IEnemy
    {
        public void Attack() => Console.WriteLine("Vampire attacks with fangs!");
        public void Defend() => Console.WriteLine("Vampire defends with agility!");
    }

    // --- FAMILY TREE B: INANIMATE OBJECTS ---

    // A base class for things that sit on the map (Rocks, Trees, Barrels)
    public class Prop
    {
        public double Weight { get; set; }
    }

    // THIS is where Interfaces shine:
    // 1. This class already has a parent ('Prop'). It cannot inherit from a 'Monster' class.
    // 2. But it CAN implement 'IEnemy'.
    // Result: An inanimate object that fights back.
    public class ExplodingBarrel : Prop, IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("BOOM! The barrel explodes causing area damage.");
        }

        public void Defend()
        {
            Console.WriteLine("The barrel sits quietly... it has no defense.");
        }
    }
}
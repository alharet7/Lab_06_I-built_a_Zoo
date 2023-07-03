using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Lab_06_I_built_a_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("Polo", 9, 150, true);
            Elephant elephant = new Elephant("Babar", 6, 300, false);
            Parrot parrot = new Parrot("Sparo", 2, 3, false, "small");
            Falcon falcon = new Falcon("Hakeem", 3, 45.3, true, "meduim");
            Tiger tiger = new Tiger("Sharikhan", 7, 143, true);

            //Console.WriteLine($"Bear Name :{bear.Name}");
            //Console.WriteLine($"Bear Age :{bear.Age} years old");
            //Console.WriteLine($"Bear Weight :{bear.Weight} Kg");
            //Console.WriteLine($"IS the Bear Predatory :{bear.Predatory}");

            //Lab 07 Interface --------------------------------------------

            Console.WriteLine($"Falcon Name: {falcon.Name}");
            Console.WriteLine($"==>> {falcon.MightAttack()}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Elephant Name: {elephant.Name}");
            Console.WriteLine($"==>> {elephant.MightAttack()}");
            Console.WriteLine("------------------------------");

            // Lab 07 Multi-Interfaces-------------------------------------
            Console.WriteLine($"Parrot Name: {parrot.Name}");
            Console.WriteLine($"==>> {parrot.MightAttack()}"); // 1st inetrface
            Console.WriteLine($"==>> {parrot.Play()}"); // 2nd interface

            Console.ReadKey();
        }
    }
    // Abstract base class:
    public abstract class Animal
    {
        public virtual string Name { get; set; }
        public virtual double Age { get; set; }

        public abstract string Eat();
        public abstract double Sleep();

        public virtual string Sound()
        {
            return "every Animal here have a sound";
        }
    }
}
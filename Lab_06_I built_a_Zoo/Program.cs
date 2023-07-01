using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Lab_06_I_built_a_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("Polo", 9, 150, true);
            //Elephant elephant = new Elephant();
            //Tiger tiger = new Tiger();
            //Parrot parrot = new Parrot();
            //Falcon falcon = new Falcon();

            Console.WriteLine($"Bear Name :{bear.Name}");
            Console.WriteLine($"Bear Age :{bear.Age} years old");
            Console.WriteLine($"Bear Weight :{bear.Weight} Kg");
            Console.WriteLine($"IS the Bear Predatory :{bear.Predatory}");



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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public class Parrot : Birds
    {
        public override string Name { get; set; }
        public override double Age { get; set; }
        public override double Speed { get; set; }
        public override string Size { get; set; }
        public bool Predatory { get; set; }

        public Parrot(string name, double age, double speed, bool predatory, string size)
        {
            Name = name;
            Age = age;
            Speed = speed;
            Predatory = predatory;
            Size = size;
        }
        public override string Eat()
        {
            return "Sparo eats Cereals and fruits.";
        }
        public override double Sleep()
        {
            return 6;
        }

        public bool Colorful { get { return Colorful; } set { Colorful = true; } }
        public string Speak()
        {
            return "Sparo the Parrot in the Zoo can speak with people in English";
        }
        public override string Fly()
        {
            return "Sparo can fly inside the cage";
        }
    }
}

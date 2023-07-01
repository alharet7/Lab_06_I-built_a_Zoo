using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public class Falcon : Birds
    {
        public override string Name { get; set; }
        public override double Age { get; set; }
        public override double Speed { get; set; }
        public override string Size { get; set; }
        public bool Predatory { get; set; }

        public Falcon(string name, double age, double speed, bool predatory, string size)
        {
            Name = name;
            Age = age;
            Speed = speed;
            Predatory = predatory;
            Size = size;
        }

        public override string Eat()
        {
            return "Hakeem the Falcon eats meat specialy Rabbits";
        }
        public override double Sleep()
        {
            return 4.30;
        }

        public string Hunt()
        {
            return "Hakeem can hunt in the zoo but inside the cage";
        }
        public override string Fly()
        {
            return "Hakeem the Falcon can fly inside the cage";
        }
    }
}

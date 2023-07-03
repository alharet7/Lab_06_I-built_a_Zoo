using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public class Elephant : Mammals, IAttack
    {
        public override string Name { get; set; }
        public override double Age { get; set; }
        public override double Weight { get; set; }
        public override bool Predatory { get; set; }
        public Elephant(string name, double age, double weight, bool predatory)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Predatory = predatory;
        }
        public override string Eat()
        {
            return "Babar eats herbs and trees";
        }
        public override double Sleep()
        {
            return 6;
        }

        private double Height
        {
            get { return Height; }
            set { Height = 4; }
        }
        public string Play()
        {
            return "Babar can play with ball and rope";
        }
        public string ElephantHeight()
        {
            return $"{Name} color is {Height}";
        }

        public string MightAttack()
        {
            return $"{Name} Calm, and does not attack.";
        }
    }
}

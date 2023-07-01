using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public class Bear : Mammals
    {
        public override string Name { get; set; }
        public override double Age { get; set; }
        public override double Weight { get; set; }
        public override bool Predatory { get; set; }
        public Bear(string name, double age, double weight, bool predatory)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Predatory = predatory;
        }

        public override string Run()
        {
            return " Polo the bear can run with average speed 30m/h";
        }
        public override string Eat()
        {
            return "Polo eats Fish";
        }
        public override double Sleep()
        {
            return 11.5;
        }
        private string Colors
        {
            get { return Colors; }
            set { Colors = "black"; }
        }

        public string Drink()
        {
            return "Polo can drink 100L/day of water ";
        }
        public string Color()
        {
            return $"{Name} color is {Colors}";
        }
    }
}

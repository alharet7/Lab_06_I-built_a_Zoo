using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public class Tiger : Mammals
    {
        public override string Name { get; set; }
        public override double Age { get; set; }
        public override double Weight { get; set; }
        public override bool Predatory { get; set; }
        public Tiger(string name, double age, double weight, bool predatory)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Predatory = predatory;
        }
        public override string Run()
        {
            return " Sharikhan the tiger can run with average speed 40m/h";
        }
        public override string Eat()
        {
            return "Sharikhan eats meat";
        }
        public override double Sleep()
        {
            return 7;
        }
        private string Type
        {
            get { return Type; }
            set { Type = "Siberian"; }
        }
        public string mating()
        {
            return "Sharikhan in the zoo cant mating!!";
        }
        public string TigerType()
        {
            return $"{Name} color is {Type}";
        }
    }
}

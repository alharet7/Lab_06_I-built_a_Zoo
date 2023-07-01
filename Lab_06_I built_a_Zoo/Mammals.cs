using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public abstract class Mammals : Animal
    {
        public abstract double Weight { get; set; }
        public abstract bool Predatory { get; set; }

        public virtual string Run()
        {
            return " Mammals can run with avareg speed 40km/1h";
        }
    }
}

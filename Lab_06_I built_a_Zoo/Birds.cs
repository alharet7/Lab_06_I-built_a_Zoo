using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_I_built_a_Zoo
{
    public abstract class Birds : Animal
    {
        public virtual string Size { get; set; }

        public virtual double Speed { get; set; }

        public virtual string Fly()
        {
            return "Every bird in the Zoo can fly inside the cage";
        }
    }
}

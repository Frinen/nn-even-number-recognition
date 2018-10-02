using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    public class Perceptron
    {
        public Perceptron(Random rnd)
        {
            Input = 0;
            Weight = rnd.Next(10000);
        }
        public int Input { get; set; }
        public int Weight { get; set; }
        public int Output()
        {
            return Input * Weight;
        }
    }
}

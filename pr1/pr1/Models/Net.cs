using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    class Net
    {
        public List<Perceptron> Perceptrons { get; set; }
        public int Teta;
        public int Sum;
        public Net()
        {
            Random rnd = new Random();
            Teta = rnd.Next(10); 
            Sum = 0;
            Perceptrons = new List<Perceptron>();
            for (int i = 0; i < 15; i++)
            {
                Perceptrons.Add(new Perceptron(rnd));
            }
            
        }
        public void Train(List<Number> Numbers)
        {
            for (int j = 0; j < 100; j++)
            {
                foreach (var Number in Numbers)
                {
                    Sum = 0;
                    for (int i = 0; i < 15; i++)
                    {
                        Perceptrons[i].Input = Number.pixels[i];
                        Sum += Perceptrons[i].Output();
                    }
                    bool output = Sum >= Teta;
                    while (output != Number.Even)
                    {
                        if (Convert.ToInt32(output) < Convert.ToInt32(Number.Even))
                        {
                            Sum = 0;
                            for (int i = 0; i < 15; i++)
                            {
                                Perceptrons[i].Weight += Perceptrons[i].Input;
                                Sum += Perceptrons[i].Output();
                            }

                        }
                        if (Convert.ToInt32(output) > Convert.ToInt32(Number.Even))
                        {
                            Sum = 0;
                            for (int i = 0; i < 15; i++)
                            {
                                Perceptrons[i].Weight -= Perceptrons[i].Input;
                                Sum += Perceptrons[i].Output();
                            }

                        }
                        output = Sum >= Teta;
                    }

                }
            }
        }

        public bool Check(List<Sensor> sensors)
        {
            Sum = 0;
            for (int i = 0; i < 15; i++)
            {
                Perceptrons[i].Input = sensors[i].Input;
            }

            foreach (var Perceptron in Perceptrons)
            {
                Sum += Perceptron.Output();
            }
            bool output = Sum >= Teta;
            return output;
        }
    }
}

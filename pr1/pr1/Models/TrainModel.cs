using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1.Models
{
    public class TrainModel
    {
        public List<Number> Numbers { get; set; }

        public TrainModel()
        {
            Numbers = new List<Number>() {
            new Number(new int[]
            {
                0,1,0,
                1,1,0,
                0,1,0,
                0,1,0,
                1,1,1
            }, false),
            new Number(new int[]
            {
                1,1,1,
                0,0,1,
                1,1,1,
                1,0,0,
                1,1,1
            }, true),
            new Number(new int[]
            {
                1,1,1,
                0,0,1,
                1,1,1,
                0,0,1,
                1,1,1
            }, false),
            new Number(new int[]
            {
                1,0,1,
                1,0,1,
                1,1,1,
                0,0,1,
                0,0,1
            }, true),
            new Number(new int[]
            {
                1,1,1,
                1,0,0,
                1,1,1,
                0,0,1,
                1,1,1
            }, false),
            new Number(new int[]
            {
                1,1,1,
                1,0,0,
                1,1,1,
                1,0,1,
                1,1,1
            }, true),
            new Number(new int[]
            {
                1,1,1,
                0,0,1,
                0,0,1,
                0,0,1,
                0,0,1
            }, false),
            new Number(new int[]
            {
                1,1,1,
                1,0,1,
                1,1,1,
                1,0,1,
                1,1,1
            }, true),
            new Number(new int[]
            {
                1,1,1,
                1,0,1,
                1,1,1,
                0,0,1,
                1,1,1
            }, false),
            };
        }
    }
    public class Number
    {
        public bool Even;
        public Number(int [] mas,bool even)
        {
            pixels = mas.ToList();
            Even = even;
        }
        public List<int> pixels { get; set; }
    }
}

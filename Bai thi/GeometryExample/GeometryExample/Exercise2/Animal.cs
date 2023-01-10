using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.Exercise2
{
    internal class Animal
    {
        public double weight { get; set; }
        public string name { get; set; }

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Name: " + name);
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}

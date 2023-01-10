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

        public Animal(string name, double weight)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Weight: " + weight);
            
        }

        public void SetMe(string name, double weight)
        {
            this.weight = weight;
            this.name = name;
        }
    }
}

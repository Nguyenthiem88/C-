using GeometryExample.Exercise1;
using GeometryExample.Exercise2;

class Program
{
   static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder(38.64, 22.48);
        cylinder.Process();

        Console.WriteLine(cylinder.Result());

    }


    static void Main1(string[] args)
    {
        Lion l = new Lion("Lion", 100);
        
        l.Show();
        Tiger t = new Tiger("tiger", 200);
        
        t.Show();
    }
}
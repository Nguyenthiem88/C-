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
        Lion l = new Lion(12.5, "Lion");
        l.Show();
        l.SetMe(10, "Li");
        l.Show();
        Tiger t = new Tiger(55, "tiger");
        t.Show();
        t.SetMe(33, "ti");
        t.Show();
    }
}
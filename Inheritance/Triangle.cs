// See https://aka.ms/new-console-template for more information

class Triangle : Shape, IShape
{
    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
        Hypotenuese = hyp;
    }

    public Triangle(int hyp, int height, int length)
    {
        Hypotenuese = hyp;
        Height = height;
        Length = length;
    }
    public double Hypotenuese { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}
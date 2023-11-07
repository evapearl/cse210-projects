using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        List<Shape> Shapes = new List<Shape>();

        Square s1 = new Square ("Red", 3);
        Shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4 , 5);
        Shape.Add(s2);

        Circle s3 = new Circle("Green", 6);
        Shapes.Add(s3);

        foreach (Shape s in Shapes)
        {
            string Colour = s.GetColour();

            double area = s.GetArea();

            Console.WriteLine($"The colour {Colour} shape has an area of {area}.");
        }
    }
}